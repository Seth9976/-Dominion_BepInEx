using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameEvent
{
	// Token: 0x0200013A RID: 314
	[StructLayout(2)]
	public struct TutorialAISelectedOption
	{
		// Token: 0x060021E5 RID: 8677 RVA: 0x00080434 File Offset: 0x0007E634
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialAISelectedOption()
		{
			Il2CppClassPointerStore<TutorialAISelectedOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameEvent", "TutorialAISelectedOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialAISelectedOption>.NativeClassPtr);
			TutorialAISelectedOption.NativeFieldInfoPtr_selection_hint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAISelectedOption>.NativeClassPtr, "selection_hint");
			TutorialAISelectedOption.NativeFieldInfoPtr_selection_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialAISelectedOption>.NativeClassPtr, "selection_id");
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000152CE File Offset: 0x000134CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TutorialAISelectedOption>.NativeClassPtr, ref this));
		}

		// Token: 0x04001710 RID: 5904
		private static readonly IntPtr NativeFieldInfoPtr_selection_hint;

		// Token: 0x04001711 RID: 5905
		private static readonly IntPtr NativeFieldInfoPtr_selection_id;

		// Token: 0x04001712 RID: 5906
		[FieldOffset(0)]
		public ushort selection_hint;

		// Token: 0x04001713 RID: 5907
		[FieldOffset(2)]
		public ushort selection_id;
	}
}
