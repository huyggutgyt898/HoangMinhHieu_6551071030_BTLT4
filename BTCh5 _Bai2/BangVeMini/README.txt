BẢNG VẼ MINI - WinForms C# (.NET 10)

Cách chạy:
1. Giải nén file zip.
2. Mở BangVeMini.csproj bằng Visual Studio (workload ".NET desktop development") rồi nhấn F5.
   Hoặc dùng dòng lệnh:  dotnet run

Nếu dùng .NET Framework 4.x: đổi TargetFramework thành net48, bỏ ImplicitUsings
và thêm các using System; System.Collections.Generic; System.Drawing; System.Windows.Forms; System.Linq.

Chức năng:
- Giữ chuột trái và kéo trên pnlCanvas -> vẽ nét liên tục.
- lblViTri hiển thị tọa độ X, Y liên tục khi di chuyển chuột.
- Chuột phải -> xóa toàn bộ (Invalidate).
- lblTrangThai: "Đang vẽ..." khi giữ chuột, "Sẵn sàng" khi nhả.
