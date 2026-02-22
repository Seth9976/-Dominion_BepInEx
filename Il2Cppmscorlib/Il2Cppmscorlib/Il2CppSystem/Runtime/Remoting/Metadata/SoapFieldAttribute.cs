using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003DA RID: 986
	public sealed class SoapFieldAttribute : SoapAttribute
	{
		// Token: 0x06003EA8 RID: 16040 RVA: 0x001247B0 File Offset: 0x001229B0
		// Note: this type is marked as 'beforefieldinit'.
		static SoapFieldAttribute()
		{
			Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapFieldAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr);
			SoapFieldAttribute.NativeFieldInfoPtr__elementName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, "_elementName");
			SoapFieldAttribute.NativeFieldInfoPtr__isElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, "_isElement");
			SoapFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672493);
			SoapFieldAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672494);
			SoapFieldAttribute.NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672495);
			SoapFieldAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr, 100672496);
		}

		// Token: 0x06003EA9 RID: 16041 RVA: 0x00124858 File Offset: 0x00122A58
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapFieldAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapFieldAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x06003EAA RID: 16042 RVA: 0x00124894 File Offset: 0x00122A94
		public unsafe string XmlElementName
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 8042, RefRangeEnd = 8044, XrefRangeStart = 8042, XrefRangeEnd = 8044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003EAB RID: 16043 RVA: 0x001248CC File Offset: 0x00122ACC
		[CallerCount(0)]
		public unsafe bool IsInteropXmlElement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003EAC RID: 16044 RVA: 0x00124908 File Offset: 0x00122B08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 353945, XrefRangeEnd = 353947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapFieldAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EAD RID: 16045 RVA: 0x000179FF File Offset: 0x00015BFF
		public SoapFieldAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x06003EAE RID: 16046 RVA: 0x0012494C File Offset: 0x00122B4C
		// (set) Token: 0x06003EAF RID: 16047 RVA: 0x00017A08 File Offset: 0x00015C08
		public unsafe string _elementName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__elementName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__elementName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x06003EB0 RID: 16048 RVA: 0x00124974 File Offset: 0x00122B74
		// (set) Token: 0x06003EB1 RID: 16049 RVA: 0x00017A27 File Offset: 0x00015C27
		public unsafe bool _isElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__isElement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapFieldAttribute.NativeFieldInfoPtr__isElement)) = value;
			}
		}

		// Token: 0x04003396 RID: 13206
		private static readonly IntPtr NativeFieldInfoPtr__elementName;

		// Token: 0x04003397 RID: 13207
		private static readonly IntPtr NativeFieldInfoPtr__isElement;

		// Token: 0x04003398 RID: 13208
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003399 RID: 13209
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlElementName_Public_get_String_0;

		// Token: 0x0400339A RID: 13210
		private static readonly IntPtr NativeMethodInfoPtr_IsInteropXmlElement_Public_Boolean_0;

		// Token: 0x0400339B RID: 13211
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_Void_Object_0;
	}
}
