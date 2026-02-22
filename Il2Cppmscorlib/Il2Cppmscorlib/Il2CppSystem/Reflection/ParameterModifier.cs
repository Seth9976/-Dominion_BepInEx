using System;
using System.Reflection;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001B5 RID: 437
	[DefaultMember("Item")]
	[Serializable]
	public sealed class ParameterModifier : ValueType
	{
		// Token: 0x06001C2B RID: 7211 RVA: 0x00009AF5 File Offset: 0x00007CF5
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterModifier()
		{
			Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ParameterModifier");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr);
			ParameterModifier.NativeFieldInfoPtr__byRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr, "_byRef");
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00009B2E File Offset: 0x00007D2E
		public ParameterModifier(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00009B37 File Offset: 0x00007D37
		public ParameterModifier()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterModifier>.NativeClassPtr))
		{
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x000A0C20 File Offset: 0x0009EE20
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00009B49 File Offset: 0x00007D49
		public unsafe Il2CppStructArray<bool> _byRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterModifier.NativeFieldInfoPtr__byRef);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParameterModifier.NativeFieldInfoPtr__byRef), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040019EC RID: 6636
		private static readonly IntPtr NativeFieldInfoPtr__byRef;
	}
}
