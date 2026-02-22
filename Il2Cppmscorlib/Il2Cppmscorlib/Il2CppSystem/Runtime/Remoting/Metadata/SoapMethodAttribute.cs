using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DB RID: 987
	public sealed class SoapMethodAttribute : SoapAttribute
	{
		// Token: 0x06003EB2 RID: 16050 RVA: 0x0012499C File Offset: 0x00122B9C
		// Note: this type is marked as 'beforefieldinit'.
		static SoapMethodAttribute()
		{
			Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapMethodAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr);
			SoapMethodAttribute.NativeFieldInfoPtr__responseElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_responseElement");
			SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_responseNamespace");
			SoapMethodAttribute.NativeFieldInfoPtr__returnElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_returnElement");
			SoapMethodAttribute.NativeFieldInfoPtr__soapAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_soapAction");
			SoapMethodAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_useAttribute");
			SoapMethodAttribute.NativeFieldInfoPtr__namespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, "_namespace");
			SoapMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672497);
			SoapMethodAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672498);
			SoapMethodAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672499);
			SoapMethodAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr, 100672500);
		}

		// Token: 0x06003EB3 RID: 16051 RVA: 0x00124A94 File Offset: 0x00122C94
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapMethodAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapMethodAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FC5 RID: 4037
		// (get) Token: 0x06003EB4 RID: 16052 RVA: 0x00124AD0 File Offset: 0x00122CD0
		public unsafe override bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FC6 RID: 4038
		// (get) Token: 0x06003EB5 RID: 16053 RVA: 0x00124B0C File Offset: 0x00122D0C
		public unsafe override string XmlNamespace
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003EB6 RID: 16054 RVA: 0x00124B44 File Offset: 0x00122D44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353947, XrefRangeEnd = 354006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapMethodAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EB7 RID: 16055 RVA: 0x00017A42 File Offset: 0x00015C42
		public SoapMethodAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x06003EB8 RID: 16056 RVA: 0x00124B88 File Offset: 0x00122D88
		// (set) Token: 0x06003EB9 RID: 16057 RVA: 0x00017A4B File Offset: 0x00015C4B
		public unsafe string _responseElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseElement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseElement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x06003EBA RID: 16058 RVA: 0x00124BB0 File Offset: 0x00122DB0
		// (set) Token: 0x06003EBB RID: 16059 RVA: 0x00017A6A File Offset: 0x00015C6A
		public unsafe string _responseNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__responseNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06003EBC RID: 16060 RVA: 0x00124BD8 File Offset: 0x00122DD8
		// (set) Token: 0x06003EBD RID: 16061 RVA: 0x00017A89 File Offset: 0x00015C89
		public unsafe string _returnElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__returnElement);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__returnElement), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06003EBE RID: 16062 RVA: 0x00124C00 File Offset: 0x00122E00
		// (set) Token: 0x06003EBF RID: 16063 RVA: 0x00017AA8 File Offset: 0x00015CA8
		public unsafe string _soapAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__soapAction);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__soapAction), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06003EC0 RID: 16064 RVA: 0x00124C28 File Offset: 0x00122E28
		// (set) Token: 0x06003EC1 RID: 16065 RVA: 0x00017AC7 File Offset: 0x00015CC7
		public new unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x17000FC4 RID: 4036
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x00124C50 File Offset: 0x00122E50
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x00017AE2 File Offset: 0x00015CE2
		public unsafe string _namespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__namespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapMethodAttribute.NativeFieldInfoPtr__namespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400339C RID: 13212
		private static readonly IntPtr NativeFieldInfoPtr__responseElement;

		// Token: 0x0400339D RID: 13213
		private static readonly IntPtr NativeFieldInfoPtr__responseNamespace;

		// Token: 0x0400339E RID: 13214
		private static readonly IntPtr NativeFieldInfoPtr__returnElement;

		// Token: 0x0400339F RID: 13215
		private static readonly IntPtr NativeFieldInfoPtr__soapAction;

		// Token: 0x040033A0 RID: 13216
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x040033A1 RID: 13217
		private static readonly IntPtr NativeFieldInfoPtr__namespace;

		// Token: 0x040033A2 RID: 13218
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040033A3 RID: 13219
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_get_Boolean_0;

		// Token: 0x040033A4 RID: 13220
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_get_String_0;

		// Token: 0x040033A5 RID: 13221
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
