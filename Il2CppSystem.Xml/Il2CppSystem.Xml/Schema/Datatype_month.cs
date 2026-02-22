using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A7 RID: 167
	public class Datatype_month : Datatype_dateTimeBase
	{
		// Token: 0x06000B4B RID: 2891 RVA: 0x00037414 File Offset: 0x00035614
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_month()
		{
			Il2CppClassPointerStore<Datatype_month>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_month");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr);
			Datatype_month.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr, 100664959);
			Datatype_month.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr, 100664960);
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06000B4C RID: 2892 RVA: 0x0003746C File Offset: 0x0003566C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_month.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000374B4 File Offset: 0x000356B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22871, XrefRangeEnd = 22875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_month()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_month>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_month.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00005E37 File Offset: 0x00004037
		public Datatype_month(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
