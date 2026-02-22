using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A3 RID: 163
	public class Datatype_yearMonth : Datatype_dateTimeBase
	{
		// Token: 0x06000B3B RID: 2875 RVA: 0x000370A4 File Offset: 0x000352A4
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_yearMonth()
		{
			Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_yearMonth");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr);
			Datatype_yearMonth.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr, 100664951);
			Datatype_yearMonth.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr, 100664952);
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06000B3C RID: 2876 RVA: 0x000370FC File Offset: 0x000352FC
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_yearMonth.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00037144 File Offset: 0x00035344
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22855, XrefRangeEnd = 22859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_yearMonth()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_yearMonth>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_yearMonth.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x00005E13 File Offset: 0x00004013
		public Datatype_yearMonth(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
