using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000075 RID: 117
	public class UpaException : Exception
	{
		// Token: 0x060008B0 RID: 2224 RVA: 0x0002E828 File Offset: 0x0002CA28
		// Note: this type is marked as 'beforefieldinit'.
		static UpaException()
		{
			Il2CppClassPointerStore<UpaException>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "UpaException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpaException>.NativeClassPtr);
			UpaException.NativeFieldInfoPtr_particle1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpaException>.NativeClassPtr, "particle1");
			UpaException.NativeFieldInfoPtr_particle2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpaException>.NativeClassPtr, "particle2");
			UpaException.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpaException>.NativeClassPtr, 100664714);
		}

		// Token: 0x060008B1 RID: 2225 RVA: 0x0002E894 File Offset: 0x0002CA94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 21420, XrefRangeEnd = 21424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UpaException(Object particle1, Object particle2)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UpaException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(particle1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(particle2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UpaException.NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x00004C46 File Offset: 0x00002E46
		public UpaException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0002E8F4 File Offset: 0x0002CAF4
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00004C4F File Offset: 0x00002E4F
		public unsafe Object particle1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0002E924 File Offset: 0x0002CB24
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00004C6E File Offset: 0x00002E6E
		public unsafe Object particle2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UpaException.NativeFieldInfoPtr_particle2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006D7 RID: 1751
		private static readonly IntPtr NativeFieldInfoPtr_particle1;

		// Token: 0x040006D8 RID: 1752
		private static readonly IntPtr NativeFieldInfoPtr_particle2;

		// Token: 0x040006D9 RID: 1753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_Object_0;
	}
}
