using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Runtime.Remoting.Metadata;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000393 RID: 915
	public class InternalRemotingServices : Object
	{
		// Token: 0x06003B69 RID: 15209 RVA: 0x00118870 File Offset: 0x00116A70
		// Note: this type is marked as 'beforefieldinit'.
		static InternalRemotingServices()
		{
			Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "InternalRemotingServices");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr);
			InternalRemotingServices.NativeFieldInfoPtr__soapAttributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, "_soapAttributes");
			InternalRemotingServices.NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InternalRemotingServices>.NativeClassPtr, 100672078);
		}

		// Token: 0x06003B6A RID: 15210 RVA: 0x001188C8 File Offset: 0x00116AC8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 348861, RefRangeEnd = 348866, XrefRangeStart = 348803, XrefRangeEnd = 348861, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SoapAttribute GetCachedSoapAttribute(Object reflectionObject)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InternalRemotingServices.NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SoapAttribute>(intPtr3) : null;
			}
		}

		// Token: 0x06003B6B RID: 15211 RVA: 0x00016607 File Offset: 0x00014807
		public InternalRemotingServices(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06003B6C RID: 15212 RVA: 0x0011890C File Offset: 0x00116B0C
		// (set) Token: 0x06003B6D RID: 15213 RVA: 0x00016610 File Offset: 0x00014810
		public unsafe static Hashtable _soapAttributes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(InternalRemotingServices.NativeFieldInfoPtr__soapAttributes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Hashtable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InternalRemotingServices.NativeFieldInfoPtr__soapAttributes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003170 RID: 12656
		private static readonly IntPtr NativeFieldInfoPtr__soapAttributes;

		// Token: 0x04003171 RID: 12657
		private static readonly IntPtr NativeMethodInfoPtr_GetCachedSoapAttribute_Public_Static_SoapAttribute_Object_0;
	}
}
