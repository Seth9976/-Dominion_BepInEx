using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A6 RID: 166
	public class Datatype_day : Datatype_dateTimeBase
	{
		// Token: 0x06000B47 RID: 2887 RVA: 0x00037338 File Offset: 0x00035538
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_day()
		{
			Il2CppClassPointerStore<Datatype_day>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_day");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr);
			Datatype_day.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr, 100664957);
			Datatype_day.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr, 100664958);
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06000B48 RID: 2888 RVA: 0x00037390 File Offset: 0x00035590
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_day.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000373D8 File Offset: 0x000355D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22867, XrefRangeEnd = 22871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_day()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_day>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_day.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00005E2E File Offset: 0x0000402E
		public Datatype_day(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
