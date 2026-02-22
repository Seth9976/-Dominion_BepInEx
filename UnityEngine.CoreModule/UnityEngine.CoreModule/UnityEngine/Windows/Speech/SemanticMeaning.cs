using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000F2 RID: 242
	public sealed class SemanticMeaning : ValueType
	{
		// Token: 0x060014C7 RID: 5319 RVA: 0x0004F618 File Offset: 0x0004D818
		// Note: this type is marked as 'beforefieldinit'.
		static SemanticMeaning()
		{
			Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "SemanticMeaning");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr);
			SemanticMeaning.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "key");
			SemanticMeaning.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr, "values");
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0000BF64 File Offset: 0x0000A164
		public SemanticMeaning(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0000BF6D File Offset: 0x0000A16D
		public SemanticMeaning()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SemanticMeaning>.NativeClassPtr))
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060014CA RID: 5322 RVA: 0x0004F670 File Offset: 0x0004D870
		// (set) Token: 0x060014CB RID: 5323 RVA: 0x0000BF7F File Offset: 0x0000A17F
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060014CC RID: 5324 RVA: 0x0004F698 File Offset: 0x0004D898
		// (set) Token: 0x060014CD RID: 5325 RVA: 0x0000BF9E File Offset: 0x0000A19E
		public unsafe Il2CppStringArray values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SemanticMeaning.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F7E RID: 3966
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x04000F7F RID: 3967
		private static readonly IntPtr NativeFieldInfoPtr_values;
	}
}
