using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A4 RID: 164
	public class Datatype_year : Datatype_dateTimeBase
	{
		// Token: 0x06000B3F RID: 2879 RVA: 0x00037180 File Offset: 0x00035380
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_year()
		{
			Il2CppClassPointerStore<Datatype_year>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_year");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr);
			Datatype_year.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr, 100664953);
			Datatype_year.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr, 100664954);
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06000B40 RID: 2880 RVA: 0x000371D8 File Offset: 0x000353D8
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_year.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x00037220 File Offset: 0x00035420
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22859, XrefRangeEnd = 22863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_year()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_year>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_year.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x00005E1C File Offset: 0x0000401C
		public Datatype_year(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
