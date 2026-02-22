using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200046C RID: 1132
	public sealed class LowLevelComparer : Object
	{
		// Token: 0x060043AF RID: 17327 RVA: 0x001359B8 File Offset: 0x00133BB8
		// Note: this type is marked as 'beforefieldinit'.
		static LowLevelComparer()
		{
			Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "LowLevelComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr);
			LowLevelComparer.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr, "Default");
			LowLevelComparer.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr, 100673080);
			LowLevelComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr, 100673081);
		}

		// Token: 0x060043B0 RID: 17328 RVA: 0x00135A24 File Offset: 0x00133C24
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LowLevelComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LowLevelComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelComparer.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060043B1 RID: 17329 RVA: 0x00135A60 File Offset: 0x00133C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358891, XrefRangeEnd = 358898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Compare(Object a, Object b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(b);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LowLevelComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060043B2 RID: 17330 RVA: 0x0001A06A File Offset: 0x0001826A
		public LowLevelComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700113C RID: 4412
		// (get) Token: 0x060043B3 RID: 17331 RVA: 0x00135AC0 File Offset: 0x00133CC0
		// (set) Token: 0x060043B4 RID: 17332 RVA: 0x0001A073 File Offset: 0x00018273
		public unsafe static LowLevelComparer Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(LowLevelComparer.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LowLevelComparer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LowLevelComparer.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400372A RID: 14122
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x0400372B RID: 14123
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x0400372C RID: 14124
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_Object_Object_0;
	}
}
