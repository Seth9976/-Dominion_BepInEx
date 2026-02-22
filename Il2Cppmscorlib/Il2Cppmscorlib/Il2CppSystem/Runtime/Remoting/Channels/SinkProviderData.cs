using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Channels
{
	// Token: 0x020003CF RID: 975
	public class SinkProviderData : Object
	{
		// Token: 0x06003E57 RID: 15959 RVA: 0x00123588 File Offset: 0x00121788
		// Note: this type is marked as 'beforefieldinit'.
		static SinkProviderData()
		{
			Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Channels", "SinkProviderData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr);
			SinkProviderData.NativeFieldInfoPtr_sinkName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "sinkName");
			SinkProviderData.NativeFieldInfoPtr_children = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "children");
			SinkProviderData.NativeFieldInfoPtr_properties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, "properties");
			SinkProviderData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100672456);
			SinkProviderData.NativeMethodInfoPtr_get_Children_Public_get_IList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100672457);
			SinkProviderData.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr, 100672458);
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x00123630 File Offset: 0x00121830
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353617, RefRangeEnd = 353619, XrefRangeStart = 353608, XrefRangeEnd = 353617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SinkProviderData(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SinkProviderData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x06003E59 RID: 15961 RVA: 0x0012367C File Offset: 0x0012187C
		public unsafe IList Children
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr_get_Children_Public_get_IList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList>(intPtr3) : null;
			}
		}

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x06003E5A RID: 15962 RVA: 0x001236BC File Offset: 0x001218BC
		public unsafe IDictionary Properties
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SinkProviderData.NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06003E5B RID: 15963 RVA: 0x0001783D File Offset: 0x00015A3D
		public SinkProviderData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x06003E5C RID: 15964 RVA: 0x001236FC File Offset: 0x001218FC
		// (set) Token: 0x06003E5D RID: 15965 RVA: 0x00017846 File Offset: 0x00015A46
		public unsafe string sinkName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_sinkName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_sinkName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x06003E5E RID: 15966 RVA: 0x00123724 File Offset: 0x00121924
		// (set) Token: 0x06003E5F RID: 15967 RVA: 0x00017865 File Offset: 0x00015A65
		public unsafe ArrayList children
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_children);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_children), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x06003E60 RID: 15968 RVA: 0x00123754 File Offset: 0x00121954
		// (set) Token: 0x06003E61 RID: 15969 RVA: 0x00017884 File Offset: 0x00015A84
		public unsafe Hashtable properties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_properties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SinkProviderData.NativeFieldInfoPtr_properties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003366 RID: 13158
		private static readonly IntPtr NativeFieldInfoPtr_sinkName;

		// Token: 0x04003367 RID: 13159
		private static readonly IntPtr NativeFieldInfoPtr_children;

		// Token: 0x04003368 RID: 13160
		private static readonly IntPtr NativeFieldInfoPtr_properties;

		// Token: 0x04003369 RID: 13161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400336A RID: 13162
		private static readonly IntPtr NativeMethodInfoPtr_get_Children_Public_get_IList_0;

		// Token: 0x0400336B RID: 13163
		private static readonly IntPtr NativeMethodInfoPtr_get_Properties_Public_get_IDictionary_0;
	}
}
