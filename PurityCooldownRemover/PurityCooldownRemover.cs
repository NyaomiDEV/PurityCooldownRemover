using UnityEngine;
using BepInEx;

namespace AryToNeX {

	[BepInPlugin("pw.AryToNeX.PurityCooldownRemover", "Purity Cooldown Remover", "1.0.0")]

    public class PurityCooldownRemover : BaseUnityPlugin {

        public void Awake() {
			On.RoR2.GenericSkill.CalculateFinalRechargeInterval += (original, self) => {
				return Mathf.Min(self.baseRechargeInterval, Mathf.Max(0f, self.baseRechargeInterval * self.cooldownScale - self.flatCooldownReduction));
			};
        }

    }

}