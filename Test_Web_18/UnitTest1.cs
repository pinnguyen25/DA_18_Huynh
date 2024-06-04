using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Test_Web_18
{
    [TestClass]
    public class UnitTest1
    {
        private ChromeDriverService chromeDriverService;
        private ChromeDriver chromeDriver;
        // Khai báo biến txtSearch
        private TextBox txtSearch;

        [TestInitialize]
        public void Setup()
        {
            // Ẩn màn hình đen khi chạy
            var chromeDriverService = ChromeDriverService.CreateDefaultService();
            chromeDriverService.HideCommandPromptWindow = true;
            chromeDriver = new ChromeDriver(chromeDriverService);
        }

        [TestCleanup]
        public void TearDown()
        {
            // Đóng và giải phóng trình duyệt
            if (chromeDriver != null)
            {
                chromeDriver.Quit();
                chromeDriver.Dispose();
            }
        }

        [TestMethod]
        public void Test_btnOpen_18()
        {
            // Điều hướng đến trang web manga
            chromeDriver.Url = "https://manga.com.vn/";
            chromeDriver.Navigate();
            Thread.Sleep(3000); // Wait for the page to load

            // Kiểm tra đường link
            Assert.AreEqual("https://manga.com.vn/", chromeDriver.Url, "The browser did not navigate to manga.com.vn successfully.");
        }

        [TestMethod]
        public void Test_btnSearch_18()
        {
            Test_btnOpen_18();

            // sửa XPath để tìm kiếm phần tử không tồn tại == Failed
            var searchBar = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/header/div/div[1]/form/input"));
            // Lấy nội dung từ TextBox và tách thành một mảng các từ
            string[] searchTerms = txtSearch.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            // Ghép các từ lại thành một chuỗi, cách nhau bởi dấu cách
            string tukhoa_18 = string.Join(" ", searchTerms);

            // Kiểm tra xem ô tìm kiếm có hiển thị hay không
            //var searchBar = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/header/div/div[1]/form/input"));
            searchBar.Clear();
            searchBar.SendKeys("Conan");
            searchBar.Submit();
            Thread.Sleep(3000);
        }

        [TestMethod]
        public void Test_btnChon_18()
        {
            try
            {
                // Thực hiện tìm kiếm
                Test_btnSearch_18();
                
                // Click vào truyện đầu tiên từ kết quả tìm kiếm
                //var KQsearch_18 = chromeDriver.FindElements(By.XPath("//*[@id=\"__next\"]/main/div[2]/div/div[1]/div[2]/div[1]/div[2]/h3/a"));
                // ô khác
                var KQsearch_18 = chromeDriver.FindElements(By.XPath("//*[@id=\"__next\"]/main/header/div/div[2]/nav/ul/li[4]/a/span"));

                KQsearch_18[0].Click();
                Thread.Sleep(5000);
                Assert.IsNotNull(KQsearch_18, "Không tìm thấy truyện đã chọn.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Đã xảy ra lỗi: {ex.Message}");
            }
        }


        [TestMethod]
        public void Test_btnF_18()
        {
            try
            {
                Test_btnChon_18();
                // Kiểm tra xem đã chuyển đến chương đầu tiên hay không
                var docFist = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/div[3]/div[2]/div/div[2]/div[2]/div[4]/button[1]/span"));
                docFist.Click();
                Thread.Sleep(5000);
                Assert.IsNotNull(docFist, "Không tìm thấy nút 'Đọc từ đầu'.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [TestMethod]
        public void Test_btnN_18()
        {
            try
            {
                Test_btnChon_18();
                // Kiểm tra xem đã chuyển đến chương mới nhất hay không
                var docNew = chromeDriver.FindElement(By.XPath("//*[@id=\"__next\"]/main/div[3]/div[2]/div/div[2]/div[2]/div[4]/button[2]/span"));
                docNew.Click();
                Thread.Sleep(5000);
                Assert.IsNotNull(docNew, "Không tìm thấy nút 'Đọc mới nhất'.");

            }
            catch (Exception ex)
            {
                Assert.Fail($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        [TestMethod]
        public void Test_btnBack_18()
        {
            // Mở trang web và thực hiện tìm kiếm với từ khóa "Conan"
            Test_btnSearch_18();


            // Quay lại trang trước đó
            chromeDriver.Navigate().Back();
            Thread.Sleep(3000);

            // Kiểm tra xem đã quay lại trang tìm kiếm với từ khóa "Conan" hay không
            Assert.IsTrue(chromeDriver.Url.Contains("https://manga.com.vn/"), "Không quay lại trang tìm kiếm với từ khóa 'Conan'.");

        }

    }
}
