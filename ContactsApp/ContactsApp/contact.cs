using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp
{
    /// <summary>
    /// Класс контактов
    /// </summary>
    public class Contact : System.ICloneable
    {
        /// <summary>
        /// 
        /// </summary>
        private string _name;

        private string _secondName;

        private PhoneNumber _phone = new PhoneNumber();

        private DateTime _birth;

        private string _eMail;

        private string _idVk;

        private string UppercaseFirst(string s)
        {
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get {
                return(UppercaseFirst( _name));
            }
            set
            {
                if ((value.Length) > 50)
                {
                    throw new ArgumentException("Длинна имени не должна превышать 50 символов.");
                }
                int i = 0;

                while (i < value.Length)
                {
                    if ((value[i] < 'A') || (value[i] > 'z') || (value[i] > 'Z' && value[i] < 'a'))
                    {
                        throw new ArgumentException("Имя должно содержать только буквы.");
                    }
                    i++;
                }
                i = 0;
                if (value[i] >= 'a' && value[i] <= 'z')
                {
                    throw new ArgumentException("Имя должно начинаться с заглавной буквы.");
                }
                _name = value;
            }

        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName
        {
            get {
                return (UppercaseFirst(_secondName));
            }
            set
            {
                if ((value.Length) > 50)
                {
                    throw new ArgumentException("Длинна фамилии не должна превышать 50 символов.");
                }
                int i = 0;

                while (i < value.Length)
                {
                    if ((value[i] < 'A') || (value[i] > 'z') || (value[i] > 'Z' && value[i] < 'a'))
                    {
                        throw new ArgumentException("Фамилия должна содержать только буквы.");
                    }
                    i++;
                }
                i = 0;
                if (value[i] >= 'a' && value[i] <= 'z')
                {
                    throw new ArgumentException("Фамилия должна начинаться с заглавной буквы.");
                }
                _secondName = value;
            }
        }

        /// <summary>
        /// Телефон
        /// </summary>
        public PhoneNumber Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }

        }
        public readonly DateTime dateMin = new DateTime(1900, 01, 01);
        /// <summary>
        /// Дата рождения
        /// </summary>
       
        public DateTime Birth
        {
            get { return _birth; }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentException("Дата рождения не может быть больше текушей даты");
                }
                if (value.Year < 1900)
                {
                    throw new ArgumentException("Дата рождения не может быть быть меньше 1900 года");
                }
                _birth = value;
            }

        }
        /// <summary>
        /// Почта
        /// </summary>
        public string Email
        {
            get
            {
                return _eMail;
            }

            set
            {

                if (value.Length > 15)
                {
                    throw new ArgumentException(@"String is too long");
                }
                _eMail = value;
            }
        }
        /// <summary>
        /// ссылка ВКонтакте
        /// </summary>
        public string IDVk
        {
            get
            {
                return _idVk;
            }

            set
            {
                if (value.Length > 15)
                {
                    throw new ArgumentException(@"String is too long");
                }

                _idVk = value;
            }
        }

       
        /// <summary>
        /// Клонирование
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Contact
            {
                Name = this.Name,
                SecondName = this.SecondName,
                Phone = this.Phone,
                Birth = this.Birth,
                Email = this.Email,
                IDVk = this.IDVk
            };
        }

       
    }
}
