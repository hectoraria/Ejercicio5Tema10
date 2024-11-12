using ENT;

namespace DAL
{
    public class ClsListadoDAL
    {
        public static List<ClsPersona> listadoPersonas()
        {
            List<ClsPersona> lista = new List<ClsPersona>();

            lista.Add(new ClsPersona("Andrés", "Villanueva Ortiz", DateTime.Parse("15/03/2002"),
                "https://thispersondoesnotexist.com", "Calle del Reloj", 611223344));
            lista.Add(new ClsPersona("Beatriz", "Fuentes Morales", DateTime.Parse("05/11/1999"),
                            "https://thispersondoesnotexist.com", "Avenida de los Cedros", 654321678));
            lista.Add(new ClsPersona("Gabriel", "Pérez Olivares", DateTime.Parse("22/09/1994"),
                            "https://thispersondoesnotexist.com", "Paseo de las Flores", 676789012));
            lista.Add(new ClsPersona("Natalia", "Romero Díaz", DateTime.Parse("04/04/2001"),
                            "https://thispersondoesnotexist.com", "Calle Nueva", 623456789));
            lista.Add(new ClsPersona("Roberto", "Mendoza Fernández", DateTime.Parse("12/01/1988"),
                            "https://thispersondoesnotexist.com", "Plaza del Bosque", 612345987));
            lista.Add(new ClsPersona("Sofía", "Hernández Gómez", DateTime.Parse("18/08/1993"),
                            "https://thispersondoesnotexist.com", "Avenida Central", 634567543));

            return lista;
        }
    }
}
