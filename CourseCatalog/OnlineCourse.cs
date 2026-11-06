using System;
using System.Windows.Forms;

namespace CourseCatalog
{
    public class OnlineCourse : IIdentifiable<int>, IExportable, IComparable, ICloneable
    {
        public class AccessCertificate : ICloneable
        {
            public string CertNumber { get; private set; }
            public int ValidityDays { get; private set; }

            public AccessCertificate(string certNumber, int validityDays)
            {
                CertNumber = certNumber;
                ValidityDays = validityDays;
            }

            public object Clone()
            {
                return new AccessCertificate(CertNumber, ValidityDays);
            }

            public AccessCertificate ShallowCopy()
            {
                return (AccessCertificate)MemberwiseClone();
            }
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public AccessCertificate Certificate { get; private set; }

        public OnlineCourse(int id, string title, decimal price, AccessCertificate certificate)
        {
            Id = id;
            Title = title;
            Price = price;
            Certificate = certificate;
        }

        public void Display(ListBox listBox)
        {
            listBox.Items.Add(((IExportable)this).GetExportData());
        }

        string IExportable.GetExportData()
        {
            return $"[{Id}] Курс: {Title} | Цена: {Price} руб. | " +
                   $"Сертификат: №{Certificate.CertNumber} ({Certificate.ValidityDays} дн.)";
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            if (obj is OnlineCourse other)
                return Price.CompareTo(other.Price);
            throw new ArgumentException("Объект не является OnlineCourse", nameof(obj));
        }

        public object Clone()
        {
            return new OnlineCourse(
                Id,
                Title,
                Price,
                (AccessCertificate)Certificate.Clone());
        }
    }
}
