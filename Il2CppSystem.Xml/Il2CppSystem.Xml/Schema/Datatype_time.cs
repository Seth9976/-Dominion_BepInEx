using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A1 RID: 161
	public class Datatype_time : Datatype_dateTimeBase
	{
		// Token: 0x06000B33 RID: 2867 RVA: 0x00036EEC File Offset: 0x000350EC
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_time()
		{
			Il2CppClassPointerStore<Datatype_time>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_time");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr);
			Datatype_time.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr, 100664947);
			Datatype_time.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr, 100664948);
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00036F44 File Offset: 0x00035144
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_time.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00036F8C File Offset: 0x0003518C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22847, XrefRangeEnd = 22851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_time()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_time>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_time.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00005E01 File Offset: 0x00004001
		public Datatype_time(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
