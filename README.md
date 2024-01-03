# Hướng dẫn chạy Back-end trên Server

## Bước 1. Vào folder chứa sourcecode
```
cd Project_Pinterest/Project_Pinterest
```

## Bước 2. Kiểm tra xem database có update mới không
```
dotnet ef migrations list
```
Nếu có trạng thái pending thì thực hiện cập nhật CSDL bằng câu lệnh:
```
dotnet ef database update
```
## Bước 3. Mở terminal mới và expose cổng để truy cập bằng trình duyệt ngoài
```
/etc/jupyter/bin/expose 7028
```
<img src="https://github.com/HTVpoet/Project_Pinterest/assets/87694268/acff737a-9a6d-4a50-8f1a-876d1de9d593" />

## Bước 4. Chạy 
```
dotnet run
```

