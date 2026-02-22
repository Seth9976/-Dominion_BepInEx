using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x020002E4 RID: 740
	public class DSA : AsymmetricAlgorithm
	{
		// Token: 0x060030C9 RID: 12489 RVA: 0x000F333C File Offset: 0x000F153C
		// Note: this type is marked as 'beforefieldinit'.
		static DSA()
		{
			Il2CppClassPointerStore<DSA>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DSA");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DSA>.NativeClassPtr);
			DSA.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100670967);
			DSA.NativeMethodInfoPtr_Create_Public_Static_DSA_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100670968);
			DSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100670969);
			DSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100670970);
			DSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_DSAParameters_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100670971);
			DSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_DSAParameters_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DSA>.NativeClassPtr, 100670972);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000F33E4 File Offset: 0x000F15E4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DSA()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DSA>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSA.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000F3420 File Offset: 0x000F1620
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 339320, RefRangeEnd = 339323, XrefRangeStart = 339315, XrefRangeEnd = 339320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DSA Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DSA.NativeMethodInfoPtr_Create_Public_Static_DSA_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DSA>(intPtr3) : null;
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x000F3454 File Offset: 0x000F1654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339323, XrefRangeEnd = 339384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void FromXmlString(string xmlString)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(xmlString);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000F34A4 File Offset: 0x000F16A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 339384, XrefRangeEnd = 339461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToXmlString(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000F34F4 File Offset: 0x000F16F4
		[CallerCount(0)]
		public unsafe virtual DSAParameters ExportParameters(bool includePrivateParameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref includePrivateParameters;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_DSAParameters_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DSAParameters(intPtr);
			}
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000F3544 File Offset: 0x000F1744
		[CallerCount(0)]
		public unsafe virtual void ImportParameters(DSAParameters parameters)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(parameters));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DSA.NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_DSAParameters_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00011495 File Offset: 0x0000F695
		public DSA(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040029FB RID: 10747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040029FC RID: 10748
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DSA_0;

		// Token: 0x040029FD RID: 10749
		private static readonly IntPtr NativeMethodInfoPtr_FromXmlString_Public_Virtual_Void_String_0;

		// Token: 0x040029FE RID: 10750
		private static readonly IntPtr NativeMethodInfoPtr_ToXmlString_Public_Virtual_String_Boolean_0;

		// Token: 0x040029FF RID: 10751
		private static readonly IntPtr NativeMethodInfoPtr_ExportParameters_Public_Abstract_Virtual_New_DSAParameters_Boolean_0;

		// Token: 0x04002A00 RID: 10752
		private static readonly IntPtr NativeMethodInfoPtr_ImportParameters_Public_Abstract_Virtual_New_Void_DSAParameters_0;
	}
}
