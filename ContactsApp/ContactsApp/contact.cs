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
        public string _name;

        public string _secondName;

        public PhoneNumber _phone;

        public DateTime _birth;

        private string _eMail;

        private string _idVk;

        /// <summary>
        /// Имя
        /// </summary>
        public string Name
        {
            get
            {
               return (_name);
            }

            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(@"String is too long");
                }
            }
           
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string SecondName
        {
            get { return _secondName; }
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

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime Birth
        {
            get { return _birth; }

            set
            {
              
                if (value > DateTime.Today)
                {
                    throw new ArgumentException(@"Date must be more than 1900");
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

                if (value.Length > 50)
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
        /// Перевод первой буквы в верхний регистр
        /// </summary>
        /// <param name="str">Строка которую надо перевести</param>
        /// <returns>Строка с переведенным регистром</returns>
       // public static string FirstLetterToUpper(string str)
       // {
       //  if (str.Length > 0) { return Char.ToUpper(str[0]) + str.Substring(1); }
       //  return "";
        //}
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
