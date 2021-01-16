using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MHBookStore.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace MHBookStore.Data
{
    public class SeedData
    {
        public static void EnsurePopulate(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Từ Điển Tiếng “Em”",
                        Category = "Tiểu thuyết",
                        Author = "",
                        Description = "Bạn sẽ bất ngờ, khi cầm cuốn “từ điển” xinh xinh này trên tay.Và sẽ còn ngạc nhiên hơn nữa," +
                        "khi bắt đầu đọc từng trang sách…Dĩ nhiên là vì “Từ điển tiếng “Em” không phải là một cuốn từ điển thông thường rồi!",
                        Price = 50300,
                        UrlImage = "1.jpg"

                    },
                    new Book
                    {
                        Title = "Tô Bình Yên Vẽ Hạnh Phúc",
                        Category = "Tiểu thuyết",
                        Author = "KULZSC",
                        Description = "Tô bình yên - vẽ hạnh phúc – sắc nét phong cách cá nhân với một chút thơ thẩn,rất hiền",
                        Price = 46800,
                        UrlImage = "2.jpg"

                    },
                    new Book
                    {
                        Title = "Con Chim Xanh Biếc Bay Về",
                        Category = "Tiểu thuyết",
                        Author = "Nguyễn Nhật Ánh",
                        Description =" Như một cuốn phim “trinh thám tình yêu”,Con chim xanh biếc bay về dẫn bạn đi hết từ bất ngờ này đến tò mò suy đoán khác,để kết thúc bằng một nỗi hân hoan vô bờ sau bao phen hồi hộp nghi kỵ đến khó thở.",
                        Price = 112300,
                        UrlImage = "3.jpg"
                    },
                    new Book
                    {
                        Title = "Thay Đổi Cuộc Sống Với Nhân Số Học",
                        Category = "Tiểu thuyết",
                        Author = "DAVID A. PHILLIPS",
                        Description = "Cuốn sách Thay đổi cuộc sống với Nhân số học là tác phẩm được chị Lê Đỗ Quỳnh Hương phát triển từ tác phẩm gốc “The Complete Book of Numerology” của tiến sỹ David A. Phillips, khiến bộ môn Nhân số học khởi nguồn từ nhà toán học Pythagoras trở nên gần gũi, dễ hiểu hơn với độc giả Việt Nam.",
                        Price = 235000,
                        UrlImage = "4.jpg"
                    },
                    new Book
                    {
                        Title = "Marketing Đáng Kinh Ngạc",
                        Category = "Kinh Tế",
                        Author = "Mark W. Schaefer",
                        Description = "Cuốn sách dành cho bất cứ ai muốn trở thành một chiến binh marketing đích thực",
                        Price = 121500,
                        UrlImage = "5.jpg"
                    },
                    new Book
                    {
                        Title = "Lời Tự Thú Của Một Bậc Thầy Định Giá",
                        Category = "Kinh Tế",
                        Author = "Hermann Simon",
                        Description = "Hermann Simon- Chuyên gia hàng đầu thế giới về chiến lược định giá tiết lộ cách quy trình bí ẩn này hoạt động và cách tối đa hóa giá trị thông qua việc định giá cho công ty và khách hàng. ",
                        Price = 169000,
                        UrlImage = "6.jpg"
                    },
                    new Book
                    {
                        Title = "Ứng Dụng Trí Tuệ Nhân Tạo Vào Phân Tích Thi Trường Chứng Khoán",
                        Category = "Chứng Khoán, Đầu tư",
                        Author = "Cris DoLoc",
                        Description = "Kỷ nguyên dữ liệu và trí tuệ hiện đang mở ra những tiềm năng vô hạn và thực tế cho thấy công nghệ đang xâm chiếm thế giới, phản ánh ở những ảnh hưởng sâu sắc trên mọi mặt của đời sống kinh tế, xã hội.",
                        Price = 194500,
                        UrlImage = "7.jpg"
                    },
                    new Book
                    {
                        Title = "Đầu Tư Chứng Khoán Khôn Ngoan Khi Bạn Không Phải “Cá Mập”",
                        Category = "Chứng Khoán, Đầu tư",
                        Author = "Kevin J Davey",
                        Description = "Bạn có muốn tích lũy cho kế hoạch tương lai? Bạn có muốn gia tăng tài sản phục vụ cho những mục đích dài hạn? Bạn bắt đầu quan tâm và tìm hiểu kế hoạch tài chính cá nhân.",
                        Price = 134000,
                        UrlImage = "8.jpg"
                    },
                    new Book
                    {
                        Title = "Công Thức Thành Công Của Amazon, Apple, Facebook, Google Và Microsoft",
                        Category = "Nhân vật & bài học kinh doanh",
                        Author = "Alex Kantrowitz",
                        Description = "Always Day One - Công Thức Thành Công Của Amazon, Facebook, Google, Microsoft xuất bản vào tháng Tư năm 2020, là một ấn bản rất được mong đợi của Alex Kantrowitz.",
                        Price = 152000,
                        UrlImage = "9.jpg"
                    },
                    new Book
                    {
                        Title = "Tận Tâm Tận Lực - 101 Bài Học Kinh Doanh Thực Tiễn Cho Doanh Nhân Khởi Nghiệp",
                        Category = "Nhân vật & bài học kinh doanh",
                        Author = "Bill Green",
                        Description = "Nói đi cũng phải nói lại, tôi là tên quái nào nhỉ? Về bản chất, tôi chỉ là một tên nhóc háo thắng đã bắt đầu sự nghiệp của mình với việc ‘tự thân vận động một công ty khởi nghiệp’ từ cái thời mà ngay cả cụm từ công ty khởi nghiệp vẫn còn chưa ra đời.",
                        Price = 101500
                        ,
                        UrlImage = "10.jpg"
                    },
                    new Book
                    {
                        Title = "Hoa Hồng Xứ Khác",
                        Category = "Tiểu thuyết",
                        Author = "Nguyễn Nhật Ánh",
                        Description = "Trong truyện, Ngữ, Khoa và Hòa lé đều say mê cô bạn cùng lớp Gia Khanh. Cái cô gái bị ba người cùng theo đó sẽ phải làm sao. Ba anh chàng làm gì để “chiến thắng”. Điều lý thú là gần như tác giả tái hiện lại thời học trò của mình với ngôn ngữ thời bây giờ nên các bạn đọc trẻ sẽ tìm thấy hình bóng của chính mình trong đó.",
                        Price = 68000
                        ,
                        UrlImage = "11.jpg"
                    },
                    new Book
                    {
                        Title = "Bong Bóng Lên Trời",
                        Category = "Tiểu thuyết",
                        Author = "Nguyễn Nhật Ánh",
                        Description = "Vì hoàn cảnh, Thường phải giúp mẹ bằng nghề bán kẹo kéo ngoài giờ học và làm quen với cuộc sống trên đường phố. Ở đó cậu đánh bạn với những người nghèo và hiểu thêm nhiều điều không có trong sáchvà nhà trường. Cô bé bán bong bóng Tài Khôn hồn nhiên và nhiều ước mơ cũng thường giúp đỡ Thường thoát khỏi mặc cảm nhà nghèo và sống tự tin.",
                        Price = 49000
                        ,
                        UrlImage = "12.jpg"
                    });
                context.SaveChanges();
            }
        }
    }
}
