using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_18_Huynh
{
    public class GiaiPT_18_Huynh
    {
        // Hàm khởi tạo để gán giá trị cho các thuộc tính a, b và c.
        private float a, b, c;

        // Phương thức giải phương trình bậc nhất dạng ax + b = 0.
        public GiaiPT_18_Huynh(float a, float b, float c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public static String GiaiPT1(float a, float b)
        {
            if (a == 0)
            {
                if (b == 0)
                    return "Phương trình vô số nghiệm.";// Nếu a = 0 và b = 0
                else
                    return "Phương trình vô nghiệm.";// Nếu a = 0 và b != 0
            }
            else
            {
                return "" + (-b / a); // Nếu a != 0, trả về nghiệm duy nhất của phương trình
            }
        }

        // Phương thức giải phương trình bậc hai dạng ax^2 + bx + c = 0.
        public static String GiaiPT2(float a, float b, float c)
        {
            if (a == 0)
            {
                return GiaiPT1(b, c); // Nếu a = 0, gọi phương thức GiaiPT1 để giải phương trình bậc nhất
            }

            else
            {
                float d = b * b - 4 * a * c;// Tính delta = b^2 - 4ac
                if (d < 0) 
                {
                    return "Phương trình vô nghiệm."; // Nếu d < 0
                }
                else if (d == 0)
                {
                    return "x1=x2= " + (-b / (2 * a)); // Nếu d = 0, nghiệm kép
                }
                else
                {
                    float x1 = ((float)(-b + Math.Sqrt(d))) / (2 * a);
                    float x2 = ((float)(-b - Math.Sqrt(d))) / (2 * a);
                    return "x1=" + x1 + "  " + "x2=" + x2; // Nếu d > 0, hai nghiệm phân biệt
                }

            }
        }
    }
    
}
