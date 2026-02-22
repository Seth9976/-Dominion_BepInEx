using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000A5 RID: 165
	public class Datatype_monthDay : Datatype_dateTimeBase
	{
		// Token: 0x06000B43 RID: 2883 RVA: 0x0003725C File Offset: 0x0003545C
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_monthDay()
		{
			Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_monthDay");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr);
			Datatype_monthDay.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr, 100664955);
			Datatype_monthDay.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr, 100664956);
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000372B4 File Offset: 0x000354B4
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_monthDay.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000372FC File Offset: 0x000354FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 22863, XrefRangeEnd = 22867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_monthDay()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_monthDay>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_monthDay.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00005E25 File Offset: 0x00004025
		public Datatype_monthDay(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
