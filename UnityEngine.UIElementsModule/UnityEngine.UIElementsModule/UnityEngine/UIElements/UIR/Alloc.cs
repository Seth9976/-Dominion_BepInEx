using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x020000D9 RID: 217
	public sealed class Alloc : ValueType
	{
		// Token: 0x06000C2F RID: 3119 RVA: 0x00031780 File Offset: 0x0002F980
		// Note: this type is marked as 'beforefieldinit'.
		static Alloc()
		{
			Il2CppClassPointerStore<Alloc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "Alloc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Alloc>.NativeClassPtr);
			Alloc.NativeFieldInfoPtr_start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "start");
			Alloc.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "size");
			Alloc.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "handle");
			Alloc.NativeFieldInfoPtr_shortLived = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Alloc>.NativeClassPtr, "shortLived");
		}

		// Token: 0x06000C30 RID: 3120 RVA: 0x00007B4B File Offset: 0x00005D4B
		public Alloc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000C31 RID: 3121 RVA: 0x00007B54 File Offset: 0x00005D54
		public Alloc()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Alloc>.NativeClassPtr))
		{
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x00031800 File Offset: 0x0002FA00
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x00007B66 File Offset: 0x00005D66
		public unsafe uint start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_start)) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x00031828 File Offset: 0x0002FA28
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x00007B81 File Offset: 0x00005D81
		public unsafe uint size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x00031850 File Offset: 0x0002FA50
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x00007B9C File Offset: 0x00005D9C
		public unsafe Object handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x00031880 File Offset: 0x0002FA80
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x00007BBB File Offset: 0x00005DBB
		public unsafe bool shortLived
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_shortLived);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Alloc.NativeFieldInfoPtr_shortLived)) = value;
			}
		}

		// Token: 0x040006A1 RID: 1697
		private static readonly IntPtr NativeFieldInfoPtr_start;

		// Token: 0x040006A2 RID: 1698
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040006A3 RID: 1699
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x040006A4 RID: 1700
		private static readonly IntPtr NativeFieldInfoPtr_shortLived;
	}
}
