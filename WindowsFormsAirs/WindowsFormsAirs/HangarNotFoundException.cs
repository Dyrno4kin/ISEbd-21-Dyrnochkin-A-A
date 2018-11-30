using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAirs
{
    /// <summary>
    /// Класс-ошибка "Если не найден самолет по определенному месту"
    /// </summary>
    public class HangarNotFoundException : Exception
    {
        public HangarNotFoundException(int i) : base("Не найден самолет по месту " + i)
        { }
    }

}
