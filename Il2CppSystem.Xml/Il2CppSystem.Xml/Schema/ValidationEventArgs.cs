using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000E1 RID: 225
	public class ValidationEventArgs : EventArgs
	{
		// Token: 0x06000E13 RID: 3603 RVA: 0x00042EC4 File Offset: 0x000410C4
		// Note: this type is marked as 'beforefieldinit'.
		static ValidationEventArgs()
		{
			Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "ValidationEventArgs");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr);
			ValidationEventArgs.NativeFieldInfoPtr_ex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, "ex");
			ValidationEventArgs.NativeFieldInfoPtr_severity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, "severity");
			ValidationEventArgs.NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100665365);
			ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidationEventArgs>.NativeClassPtr, 100665366);
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x00042F44 File Offset: 0x00041144
		public unsafe XmlSeverityType Severity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000E15 RID: 3605 RVA: 0x00042F80 File Offset: 0x00041180
		public unsafe XmlSchemaException Exception
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValidationEventArgs.NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<XmlSchemaException>(intPtr3) : null;
			}
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00006AC3 File Offset: 0x00004CC3
		public ValidationEventArgs(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000E17 RID: 3607 RVA: 0x00042FC0 File Offset: 0x000411C0
		// (set) Token: 0x06000E18 RID: 3608 RVA: 0x00006ACC File Offset: 0x00004CCC
		public unsafe XmlSchemaException ex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_ex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XmlSchemaException>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_ex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000E19 RID: 3609 RVA: 0x00042FF0 File Offset: 0x000411F0
		// (set) Token: 0x06000E1A RID: 3610 RVA: 0x00006AEB File Offset: 0x00004CEB
		public unsafe XmlSeverityType severity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_severity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ValidationEventArgs.NativeFieldInfoPtr_severity)) = value;
			}
		}

		// Token: 0x04000A6A RID: 2666
		private static readonly IntPtr NativeFieldInfoPtr_ex;

		// Token: 0x04000A6B RID: 2667
		private static readonly IntPtr NativeFieldInfoPtr_severity;

		// Token: 0x04000A6C RID: 2668
		private static readonly IntPtr NativeMethodInfoPtr_get_Severity_Public_get_XmlSeverityType_0;

		// Token: 0x04000A6D RID: 2669
		private static readonly IntPtr NativeMethodInfoPtr_get_Exception_Public_get_XmlSchemaException_0;
	}
}
