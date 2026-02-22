using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x02000108 RID: 264
	public class MonoTypeInfo : Object
	{
		// Token: 0x0600139D RID: 5021 RVA: 0x0007CA80 File Offset: 0x0007AC80
		// Note: this type is marked as 'beforefieldinit'.
		static MonoTypeInfo()
		{
			Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MonoTypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr);
			MonoTypeInfo.NativeFieldInfoPtr_full_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, "full_name");
			MonoTypeInfo.NativeFieldInfoPtr_default_ctor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, "default_ctor");
			MonoTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr, 100666700);
		}

		// Token: 0x0600139E RID: 5022 RVA: 0x0007CAEC File Offset: 0x0007ACEC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MonoTypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MonoTypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MonoTypeInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600139F RID: 5023 RVA: 0x00006BB9 File Offset: 0x00004DB9
		public MonoTypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x0007CB28 File Offset: 0x0007AD28
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00006BC2 File Offset: 0x00004DC2
		public unsafe string full_name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_full_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_full_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x0007CB50 File Offset: 0x0007AD50
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00006BE1 File Offset: 0x00004DE1
		public unsafe MonoCMethod default_ctor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_default_ctor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MonoCMethod>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MonoTypeInfo.NativeFieldInfoPtr_default_ctor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010E5 RID: 4325
		private static readonly IntPtr NativeFieldInfoPtr_full_name;

		// Token: 0x040010E6 RID: 4326
		private static readonly IntPtr NativeFieldInfoPtr_default_ctor;

		// Token: 0x040010E7 RID: 4327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
