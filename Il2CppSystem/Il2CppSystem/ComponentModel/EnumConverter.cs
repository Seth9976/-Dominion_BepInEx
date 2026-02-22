using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200006C RID: 108
	public class EnumConverter : TypeConverter
	{
		// Token: 0x06000792 RID: 1938 RVA: 0x0002C708 File Offset: 0x0002A908
		// Note: this type is marked as 'beforefieldinit'.
		static EnumConverter()
		{
			Il2CppClassPointerStore<EnumConverter>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "EnumConverter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr);
			EnumConverter.NativeFieldInfoPtr_values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, "values");
			EnumConverter.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, "type");
			EnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr, 100664281);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0002C774 File Offset: 0x0002A974
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40954, RefRangeEnd = 40956, XrefRangeStart = 40953, XrefRangeEnd = 40954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnumConverter(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnumConverter>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnumConverter.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00005085 File Offset: 0x00003285
		public EnumConverter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x0000508E File Offset: 0x0000328E
		public unsafe TypeConverter.StandardValuesCollection values
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_values);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeConverter.StandardValuesCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_values), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x000050AD File Offset: 0x000032AD
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnumConverter.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000594 RID: 1428
		private static readonly IntPtr NativeFieldInfoPtr_values;

		// Token: 0x04000595 RID: 1429
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x04000596 RID: 1430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
