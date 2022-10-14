using System;
using System.Collections.Generic;
using DevFestSample.Models;

namespace DevFestSample.Services
{
    public class TalksRepository: ITalksRepository
    {
        public IEnumerable<Talk> GetTalks()
        {
            return new List<Talk>
            {
                new Talk("Destruyendo tu App con los ojos cerrados", "La intensión en esta charla es poder explicar cómo funciona la inyección de SQL ciega, de una forma divertida y simple. ",new Speaker("Julio Ureña", "https://puu.sh/JoNP0/95caefa434.png"), new DateTime(2022, 10, 14, 10, 0, 0), new DateTime(2022, 10, 14, 10, 45, 0)),
                new Talk("Bases de Datos NoSQL", " En esta charla ilustraremos con algunos casos prácticos como están impactando estas bases de datos en el mundo de las Apps, sitios web, entre otros softwares.",new Speaker("José Aquino", "https://puu.sh/JoNFG/4c6a62191d.png"), new DateTime(2022, 10, 14, 11, 0, 0), new DateTime(2022, 10, 14, 11, 45, 0)),
                new Talk("Switching careers", "En esta charla, se compartirá un marco para abordar el cambio de carrera desde otra industria para las personas que desean pasar con éxito a la industria tecnológica.",new Speaker("Leonardo Jimenez", "https://puu.sh/JoNQW/c779fb1b87.png"), new DateTime(2022, 10, 14, 11, 45, 0), new DateTime(2022, 10, 14, 12, 30, 0)),
                new Talk("¿Cómo crear apps que resuelven necesidades?", "Busca transmitir que si nos enfocamos en resolver problemas reales que requiere ser resultos en nuestros países o a nivel mundial, podemos crear algo que aporta, agrega valor y que también a la vez puede generar rentabilidad en el tiempo.",new Speaker("Kaury Rosario", "https://puu.sh/JoNRi/7cda49f609.png"), new DateTime(2022, 10, 14, 14, 00, 0), new DateTime(2022, 10, 14, 14, 30, 0)),

            };
        }
    }
}
