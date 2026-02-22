using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace GameData
{
	// Token: 0x02000133 RID: 307
	public sealed class CPP_String : ValueType
	{
		// Token: 0x060021D6 RID: 8662 RVA: 0x00015201 File Offset: 0x00013401
		// Note: this type is marked as 'beforefieldinit'.
		static CPP_String()
		{
			Il2CppClassPointerStore<CPP_String>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData", "CPP_String");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CPP_String>.NativeClassPtr);
			CPP_String.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CPP_String>.NativeClassPtr, "name");
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0001523A File Offset: 0x0001343A
		public CPP_String(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00015243 File Offset: 0x00013443
		public CPP_String()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CPP_String>.NativeClassPtr))
		{
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x060021D9 RID: 8665 RVA: 0x000801DC File Offset: 0x0007E3DC
		// (set) Token: 0x060021DA RID: 8666 RVA: 0x00015255 File Offset: 0x00013455
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CPP_String.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CPP_String.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040016AA RID: 5802
		private static readonly IntPtr NativeFieldInfoPtr_name;
	}
}
