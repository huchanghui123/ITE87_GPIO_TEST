using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GPIO_TEST
{
    class IT8786GPIO
    {
        /**
         * 加载dll相关处理函数
         */
        [DllImport("inpout32.dll")]
        public static extern UInt32 IsInpOutDriverOpen();
        [DllImport("inpout32.dll")]
        public static extern void Out32(short PortAddress, short Data);
        [DllImport("inpout32.dll")]
        public static extern ushort Inp32(short PortAddress);
        [DllImport("inpout32.dll")]
        public static extern void DlPortWritePortUshort(short PortAddress, ushort Data);
        [DllImport("inpout32.dll")]
        public static extern ushort DlPortReadPortUshort(short PortAddress);
        [DllImport("inpout32.dll")]
        public static extern void DlPortWritePortUlong(int PortAddress, uint Data);
        [DllImport("inpout32.dll")]
        public static extern uint DlPortReadPortUlong(int PortAddress);
        [DllImport("inpoutx64.dll")]
        public static extern bool GetPhysLong(ref int PortAddress, ref uint Data);
        [DllImport("inpoutx64.dll")]
        public static extern bool SetPhysLong(ref int PortAddress, ref uint Data);

        /*
         * 64位
         */
        [DllImport("inpoutx64.dll", EntryPoint = "IsInpOutDriverOpen")]
        public static extern UInt32 IsInpOutDriverOpen_x64();
        [DllImport("inpoutx64.dll", EntryPoint = "Out32")]
        public static extern void Out32_x64(short PortAddress, short Data);
        [DllImport("inpoutx64.dll", EntryPoint = "Inp32")]
        public static extern ushort Inp32_x64(short PortAddress);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUshort")]
        public static extern void DlPortWritePortUshort_x64(short PortAddress, ushort Data);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUshort")]
        public static extern ushort DlPortReadPortUshort_x64(short PortAddress);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortWritePortUlong")]
        public static extern void DlPortWritePortUlong_x64(int PortAddress, uint Data);
        [DllImport("inpoutx64.dll", EntryPoint = "DlPortReadPortUlong")]
        public static extern uint DlPortReadPortUlong_x64(int PortAddress);
        [DllImport("inpoutx64.dll", EntryPoint = "GetPhysLong")]
        public static extern bool GetPhysLong_x64(ref int PortAddress, ref uint Data);
        [DllImport("inpoutx64.dll", EntryPoint = "SetPhysLong")]
        public static extern bool SetPhysLong_x64(ref int PortAddress, ref uint Data);

        public static bool m_bX64 = true;

        public static short INPUT = 0;
        public static short OUTPUT = 1;
        public static short PIN_SIZE = 8;

        public static string addressPort = "2e";
        public static string dataPort = "2f";
        public static string gpbase = "a07";

        public static short HexStrToNum(string str)
        {
            return Convert.ToInt16(str, 16);
        }

        public static uint InitInpOutDriver()
        {
            uint nResult = 0;
            try
            {
                try
                {
                    Console.WriteLine("load 32 driver");
                    // 打开32位驱动，如果失败了，会引发异常，再加载64位驱动
                    nResult = IT8786GPIO.IsInpOutDriverOpen();

                    Console.WriteLine("nResult1: " + nResult);
                }
                catch (BadImageFormatException)
                {
                    Console.WriteLine("load 64 driver");
                    nResult = IT8786GPIO.IsInpOutDriverOpen_x64();
                    if (nResult != 0)
                        m_bX64 = true;
                    
                    Console.WriteLine("nResult2: " + nResult);
                }
                return nResult;
            }
            catch (DllNotFoundException ex)         // dll查找是失败异常
            {
                Console.WriteLine("异常："+ex.Message);
                return nResult;
            }
        }

        public static short readByte(short iPort)
        {
            ushort c = 0;

            try
            {
                if (m_bX64)
                    c = Inp32_x64(iPort);
                else
                    c = Inp32(iPort);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
            return (short)(c & 0xFF);
        }

        public static void writeByte(short iPort, short iData)
        {
            try
            {
                if (m_bX64)
                    Out32_x64(iPort, iData);
                else
                    Out32(iPort, iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static void InitGPIO()
        {
            try
            {
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("87"));
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("01"));
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("55"));
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("55"));

                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("07"));
                writeByte(HexStrToNum(IT8786GPIO.dataPort), HexStrToNum("07"));

                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("2C"));
                writeByte(HexStrToNum(IT8786GPIO.dataPort), HexStrToNum("89"));

                Console.WriteLine("init gpio end ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("init GPIO, An error occured:\n" + ex.Message);
            }
        }

        public static void SetGpioMode(short iData)
        {
            try
            {
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("CF"));
                writeByte(HexStrToNum(IT8786GPIO.dataPort), iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static void SetGpioVal(short iData)
        {
            try
            {
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("CF"));
                writeByte(HexStrToNum(IT8786GPIO.dataPort), HexStrToNum("FF"));
                writeByte(HexStrToNum(IT8786GPIO.gpbase), iData);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }

        public static short ReadGpioMode()
        {
            short c = 0;
            try
            {
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("CF"));
                c = readByte(HexStrToNum(IT8786GPIO.dataPort));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
            return c;
        }

        public static short ReadGpioVal()
        {
            short c = 0;
            try
            {
                //writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("CF"));
                c = readByte(HexStrToNum(IT8786GPIO.gpbase));
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
            return c;
        }

        public static void FreeGPIO()
        {
            try
            {
                writeByte(HexStrToNum(IT8786GPIO.addressPort), HexStrToNum("02"));
                writeByte(HexStrToNum(IT8786GPIO.dataPort), HexStrToNum("02"));
                Console.WriteLine("free gpio ...");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured:\n" + ex.Message);
            }
        }
    }
}
