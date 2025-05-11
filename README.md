# MatchPro 接案平台

讓使用者可以在此平台上找到對應的專業人才，來完成專案或項目，
除了刊登案件、找尋人才，也可以針對有興趣的項目進行接案，賺取額外收入！

## 🔧 技術
- C# (.NET 8.0)
- MVC
- MSSQL
- Entity Framework
- ADO.NET
- LINQ

## 💡 功能特色
使用者登入註冊，包含googel登入

案件發布與審核

排行榜每日更新（使用排程器）

## 📸 網站畫面
### 首頁
![image](https://github.com/user-attachments/assets/ca8c4273-9dfd-46a6-bacf-27c3e22fbf18)
### 登入介面
![image](https://github.com/user-attachments/assets/9363f8d2-0c38-4d77-b92b-9d216894a1f2)
### 個人頁面
![image](https://github.com/user-attachments/assets/465ac4c1-356d-4558-a885-403d3cc5379d)
### 找接案者 / 各種案件
![image](https://github.com/user-attachments/assets/1eb69623-6ce6-4d8d-ae5a-aad4a26383c0)
![image](https://github.com/user-attachments/assets/6887164f-e542-4a95-8f4d-3b8a8fe5abf3)
### 聊天室
![image](https://github.com/user-attachments/assets/31250b2f-31c8-434f-9860-d09d150f2bfe)
### 後台管理系統
![image](https://github.com/user-attachments/assets/edc3620e-14af-4dab-a442-58b2955b637d)
![image](https://github.com/user-attachments/assets/e0a71600-2d11-4be9-ae2e-5bcdb1bc9a91)
![image](https://github.com/user-attachments/assets/6a7b7a96-55b4-4f46-99bf-dafeb76e7486)
![image](https://github.com/user-attachments/assets/ed068c81-c439-4692-92ea-399a653793a4)




## 🛠️ 啟動方式
1. 克隆專案：
git clone https://github.com/0xdilemma/TeamPrj_MatchPro.git

2. 開啟 .sln 檔於 Visual Studio。

3. 使用『測試用資料表.sql』建立 GameCase 資料庫。
   
4. 於 Visual Studio 中對 BackMange 專案右鍵使用 EF Core Power Tools 進行反向工程(選擇 EF Core 8 版本)，
   勾選所有資料表並確定，之後不要勾選『在產生的程式碼中包含連線字串』之選項再按下確定。
   
5. 於 Visual Studio 的『工具』選項 >> NuGet 套件管理員 >> 套件管理器主控台，
   輸入：add-migration addIdentityTables -c ApplicationDbContext ，執行。
   再輸入：update-database -Context ApplicationDbContext，執行。

6. 按下 F5 ，執行程式，便可開始瀏覽 Match接案平台。
   
8. 若要使用 tUsers 資料表既有的用戶進行登入，密碼皆為 Aa123123。
   
10. 平台後臺管理頁面進入方式，請於平台首頁之網址後方加上 /home 便可進入後台管理系統，
    帳號：admin@example.com 密碼：Admin@12345

## 🗂️ 專案結構說明

```
BackMange/
├── Areas/                 # 模組區域（如 Admin, User 等）
├── Controllers/           # 控制器（MVC）
├── Data/                  # 資料存取層（DbContext 等）
├── DTO/                   # Data Transfer Objects
├── Hubs/                  # SignalR 或即時功能
├── Migrations/            # 資料庫遷移（EF Code First）
├── Models/                # 資料模型
├── Partials/              # 可重複使用的 View 部分
├── ViewModels/            # MVVM 的橋接物件
├── Views/                 # Razor View 檢視畫面
├── wwwroot/               # 靜態資源（JS, CSS, 圖片）
├── appsettings.json       # 專案設定檔
├── efpt.config.json       # EF Power Tools 設定檔
└── Program.cs             # 專案進入點
```

## 📄 License
### 此專案為個人作品展示用，未商業使用！！！
