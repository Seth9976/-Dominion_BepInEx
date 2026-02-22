using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x02000065 RID: 101
	public class BooleanConverter : TypeConverter
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x0002C1C4 File Offset: 0x0002A3C4
		// Note: this type is marked as 'beforefieldinit'.
		static BooleanConverter()
		{
			Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "BooleanConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr);
			BooleanConverter.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr, "values");
			BooleanConverter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr, 100664269);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0002C21C File Offset: 0x0002A41C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BooleanConverter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BooleanConverter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BooleanConverter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00004F58 File Offset: 0x00003158
		public BooleanConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0002C258 File Offset: 0x0002A458
		// (set) Token: 0x06000778 RID: 1912 RVA: 0x00004F61 File Offset: 0x00003161
		public unsafe static TypeConverter.StandardValuesCollection values
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BooleanConverter.NativeFieldInfoPtr_values, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BooleanConverter.NativeFieldInfoPtr_values, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
