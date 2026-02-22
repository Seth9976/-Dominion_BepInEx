using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200014A RID: 330
	[StructLayout(2)]
	public struct UpdateResolveEffectList
	{
		// Token: 0x06002205 RID: 8709 RVA: 0x00080B70 File Offset: 0x0007ED70
		// Note: this type is marked as 'beforefieldinit'.
		static UpdateResolveEffectList()
		{
			Il2CppClassPointerStore<UpdateResolveEffectList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "UpdateResolveEffectList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateResolveEffectList>.NativeClassPtr);
			UpdateResolveEffectList.NativeFieldInfoPtr_update_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateResolveEffectList>.NativeClassPtr, "update_type");
			UpdateResolveEffectList.NativeFieldInfoPtr_resolve_effect_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateResolveEffectList>.NativeClassPtr, "resolve_effect_index");
			UpdateResolveEffectList.NativeFieldInfoPtr_resolve_card_instance_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateResolveEffectList>.NativeClassPtr, "resolve_card_instance_id");
			UpdateResolveEffectList.NativeFieldInfoPtr_resolve_effect_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateResolveEffectList>.NativeClassPtr, "resolve_effect_type");
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00015460 File Offset: 0x00013660
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateResolveEffectList>.NativeClassPtr, ref this));
		}

		// Token: 0x0400178A RID: 6026
		private static readonly IntPtr NativeFieldInfoPtr_update_type;

		// Token: 0x0400178B RID: 6027
		private static readonly IntPtr NativeFieldInfoPtr_resolve_effect_index;

		// Token: 0x0400178C RID: 6028
		private static readonly IntPtr NativeFieldInfoPtr_resolve_card_instance_id;

		// Token: 0x0400178D RID: 6029
		private static readonly IntPtr NativeFieldInfoPtr_resolve_effect_type;

		// Token: 0x0400178E RID: 6030
		[FieldOffset(0)]
		public int update_type;

		// Token: 0x0400178F RID: 6031
		[FieldOffset(4)]
		public int resolve_effect_index;

		// Token: 0x04001790 RID: 6032
		[FieldOffset(8)]
		public int resolve_card_instance_id;

		// Token: 0x04001791 RID: 6033
		[FieldOffset(12)]
		public int resolve_effect_type;
	}
}
