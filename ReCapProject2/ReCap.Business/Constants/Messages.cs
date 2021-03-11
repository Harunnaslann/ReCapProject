using ReCap.Core.Entities.Concrete;
using ReCap.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ReCap.Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba Eklendi";
        public static string CarNameInvalid = "Araba ismi hatalı.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Ürünler Listelendi";
        public static string CarPriceInvalid = "Ürün fiyatı 0'dan büyük olmalıdır";
        public static string CarUpdated = "Ürün güncellendi";
        public static string CarDeleted = "Ürün silindi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandListed = "Marka Listelendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renkler listelendi";

        public static string UserAdded = "User eklendi";
        public static string UserUpdated = "User güncellendi";
        public static string UserDeleted = "User silindi";
        public static string UserListed = "User listelendi";

        public static string CustomerAdded = "Customer eklendi";
        public static string CustomerUpdated = "Customer güncellendi";
        public static string CustomerDeleted = "Customer silindi";
        public static string CustomerListed = "Customer listelendi";

        public static string RentalAdded = "Rental eklendi";
        public static string RentalUpdated = "Rental güncellendi";
        public static string RentalDeleted = "Rental silindi";
        public static string RentalListed = "Rental listelendi";
        public static string RentalReturnDateIsNull = "Rental return date ıs null";
        public static string CountOfCarImagesCorrect = "Bir arabanın en fazla 5 resmi olabilir";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageLimitExceeded = "5 taneden fazla resim eklenemez";
        public static string NoCarImages = "Herhangi bir araba resmi yok";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "TOken oluşturuldu";
    }
}
