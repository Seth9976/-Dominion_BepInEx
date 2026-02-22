using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace TMPro
{
	// Token: 0x020000FB RID: 251
	[Serializable]
	public class TMP_DigitValidator : TMP_InputValidator
	{
		// Token: 0x06001E17 RID: 7703 RVA: 0x000765E0 File Offset: 0x000747E0
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_DigitValidator()
		{
			Il2CppClassPointerStore<TMP_DigitValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro", "TMP_DigitValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_DigitValidator>.NativeClassPtr);
			TMP_DigitValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DigitValidator>.NativeClassPtr, 100665788);
			TMP_DigitValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_DigitValidator>.NativeClassPtr, 100665789);
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00076638 File Offset: 0x00074838
		[CallerCount(0)]
		public unsafe override char Validate(ref string text, ref int pos, char ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.ManagedStringToIl2Cpp(text);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &pos;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ch;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TMP_DigitValidator.NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			text = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000766BC File Offset: 0x000748BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_DigitValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_DigitValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_DigitValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00012C38 File Offset: 0x00010E38
		public TMP_DigitValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001471 RID: 5233
		private static readonly IntPtr NativeMethodInfoPtr_Validate_Public_Virtual_Char_byref_String_byref_Int32_Char_0;

		// Token: 0x04001472 RID: 5234
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
