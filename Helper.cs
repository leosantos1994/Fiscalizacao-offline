using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fiscalizacao.Models;
using Models;

namespace Fiscalizacao
{
    public static class Helper
    {
        public static void CarregarTela<TModel>(this Form form, TModel model)
        {
            foreach (var property in model.GetType().GetProperties())
            {
                Attribute attri = property.GetCustomAttribute(typeof(IgnorePropertyAttribute), true);
                if (attri is IgnorePropertyAttribute)
                    continue;

                Control c = form.Controls.Find(property.Name, true).FirstOrDefault();

                if (c != null)
                {
                    if (property.PropertyType.Equals(typeof(DateTime)))
                    {
                        DateTime data = new DateTime();
                        data = Convert.ToDateTime(property.GetValue(model));
                        if (data > DateTime.MinValue)
                            c.Text = data.ToString("dd/MM/yyyy");
                    }
                    else if (property.PropertyType.Equals(typeof(Boolean)))
                    {
                        c.Text = property.GetValue(model).ToString().ToLower() == "true" ? "Sim" : "Não";
                    }
                    else
                    {
                        if (property.Name.Equals("TipoPessoa"))
                        {
                            string val = property.GetValue(model).ToString();
                            c.Text = val.ToLower() == "J" ? "Jurídica" : "Física";
                        }
                        else
                            c.Text = property.GetValue(model).ToString();
                    }
                }
            }
        }

    }
}
