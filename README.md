# ChoosEat

## 目的

毎食食べたものを簡単に記録するアプリ。

## 機能一覧

| # | 機能名 | 詳細 |
|---| -- | --- |
| 1 | 食べたものの記録 | 食べたものを記録する機能。 |
| 2 | 食べたものの一覧表示 | 記録した食べたものを一覧で表示する機能。 |
| 3 | 食べたものの編集 | 記録した食べたものを編集・削除する機能。 |
| 4 | レパートリー登録 | よく食べるものをレパートリーとして登録する機能。 |

## 技術スタック

Frontend
- React
- TypeScript
- Vite

Backend
- ASP.NET Core Web API
- Entity Framework Core

Database
- SQL Server

Infrastructure
- Docker
- AWS ECS

## モノレポ構成（初期）

まずはバックエンドから開始し、以下の構成でモノレポを作成しました。

```text
ChoosEat/
├── backend/
│   ├── ChoosEat.Backend.slnx
│   ├── src/
│   │   └── ChoosEat.Api/
│   └── tests/
│       └── ChoosEat.Api.Tests/
└── README.md
```

## Backend セットアップ

### 必要環境
- .NET SDK 10

### 起動

```bash
dotnet run --project /home/runner/work/ChoosEat/ChoosEat/backend/src/ChoosEat.Api/ChoosEat.Api.csproj
```

### テスト

```bash
dotnet test /home/runner/work/ChoosEat/ChoosEat/backend/ChoosEat.Backend.slnx
```
