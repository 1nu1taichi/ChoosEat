# Backend Architecture

ChoosEat のバックエンドは **ASP.NET Core Web API** を使用して構築されています。  
小規模アプリのため、過度な抽象化を避けた **シンプルなレイヤードアーキテクチャ** を採用しています。

基本的な依存関係は以下です。

```
Controller
↓
Service (Application Logic)
↓
Repository (Data Access)
↓
Entity Framework Core
↓
SQL Server
```

責務を分離することで以下のメリットがあります。

- ビジネスロジックを整理できる
- テストしやすい構造になる
- データアクセス実装を変更しやすい

---

# ディレクトリ構成

```
backend/
├── ChoosEat.Backend.slnx
├── src/
│ └── ChoosEat.Api/
│ ├── Controllers/
│ │
│ ├── Services/
│ │
│ ├── Repositories/
│ │ └── ChoosEatDbContext.cs
│ │
│ ├── Entities/
│ │
│ └── Program.cs
│
└── tests/
└── ChoosEat.Api.Tests/
```

---

# 各レイヤーの責務

## Controllers

HTTPリクエストを受け取り、レスポンスを返す層です。

主な責務

- Requestの受け取り
- Responseの返却
- Serviceの呼び出し

Controllerにはビジネスロジックを実装しない方針とします。

## Services

アプリケーションのビジネスロジックを実装する層です。

主な責務

- ユースケースの実装
- Repositoryの呼び出し
- 必要に応じたデータ変換

## Repositories

データアクセスを担当する層です。

主な責務

- Entity Framework Core を使用したDBアクセス
- データ取得・保存処理
- ApplicationDbContextの管理

## Entities

データベースのテーブルに対応するクラスを定義する層です。

主な責務

- データベースのテーブル構造を表現
- Entity Framework Core のエンティティクラス

# 依存関係ルール

依存関係は 上位レイヤーから下位レイヤーへの一方向のみ とします。逆方向の依存は禁止します。

Controller
   ↓
Service
   ↓
Repository
   ↓
DbContext

## Dependency Injection

ASP.NET Core の DI コンテナを使用して依存関係を管理します。
