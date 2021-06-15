using System.Collections.Generic;

namespace DesafioDojo.Domain.Entities
{
    public static class Walk
    {
        public static void SwitchLights(List<Light> lights) {
            for (int i = 1; i <= lights.Count; i++) {
                for (int j = 0; j < lights.Count; j++) {
                    if ((j + 1) % i == 0)
                        lights[j].Switch();
                }
            }
        }
    }
}