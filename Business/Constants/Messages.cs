using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
  public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductsListed="Ürünler listelendi";
        public static string ProductCountCategoryError = "bu kategoride en fazla 10 ürün olmalı";
        public static string ProductNameAlreadyExists = "Bu isimde zaten ürün var ";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için ürün eklenemiyor ";
        public static string AuthorizationDenied = " Yetkiniz Yok ";
        public static string UserRegistered ="Kayıt oldu";
        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError= "Sifre hatali";
        public static string SuccessfulLogin="Giriş Başarılı";
        public static string UserAlreadyExists="";
    }
}
