using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace TMPro.Examples
{
	// Token: 0x0200010E RID: 270
	public class TMP_TextEventCheck : MonoBehaviour
	{
		// Token: 0x06001F8D RID: 8077 RVA: 0x0007A230 File Offset: 0x00078430
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_TextEventCheck()
		{
			Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "TMPro.Examples", "TMP_TextEventCheck");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr);
			TMP_TextEventCheck.NativeFieldInfoPtr_TextEventHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, "TextEventHandler");
			TMP_TextEventCheck.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, 100665868);
			TMP_TextEventCheck.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, 100665869);
			TMP_TextEventCheck.NativeMethodInfoPtr_OnCharacterSelection_Private_Void_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, 100665870);
			TMP_TextEventCheck.NativeMethodInfoPtr_OnWordSelection_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, 100665871);
			TMP_TextEventCheck.NativeMethodInfoPtr_OnLineSelection_Private_Void_String_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, 100665872);
			TMP_TextEventCheck.NativeMethodInfoPtr_OnLinkSelection_Private_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, 100665873);
			TMP_TextEventCheck.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr, 100665874);
		}

		// Token: 0x06001F8E RID: 8078 RVA: 0x0007A300 File Offset: 0x00078500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256537, XrefRangeEnd = 256582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventCheck.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F8F RID: 8079 RVA: 0x0007A334 File Offset: 0x00078534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256582, XrefRangeEnd = 256627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventCheck.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F90 RID: 8080 RVA: 0x0007A368 File Offset: 0x00078568
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256627, XrefRangeEnd = 256651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCharacterSelection(char c, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventCheck.NativeMethodInfoPtr_OnCharacterSelection_Private_Void_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F91 RID: 8081 RVA: 0x0007A3B4 File Offset: 0x000785B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256651, XrefRangeEnd = 256680, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnWordSelection(string word, int firstCharacterIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(word);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstCharacterIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventCheck.NativeMethodInfoPtr_OnWordSelection_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F92 RID: 8082 RVA: 0x0007A414 File Offset: 0x00078614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256680, XrefRangeEnd = 256709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLineSelection(string lineText, int firstCharacterIndex, int length)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(lineText);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref firstCharacterIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventCheck.NativeMethodInfoPtr_OnLineSelection_Private_Void_String_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F93 RID: 8083 RVA: 0x0007A474 File Offset: 0x00078674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 256709, XrefRangeEnd = 256737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLinkSelection(string linkID, string linkText, int linkIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(linkID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(linkText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linkIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventCheck.NativeMethodInfoPtr_OnLinkSelection_Private_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F94 RID: 8084 RVA: 0x0007A4D8 File Offset: 0x000786D8
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TMP_TextEventCheck()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TMP_TextEventCheck>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_TextEventCheck.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x00013AE9 File Offset: 0x00011CE9
		public TMP_TextEventCheck(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06001F96 RID: 8086 RVA: 0x0007A514 File Offset: 0x00078714
		// (set) Token: 0x06001F97 RID: 8087 RVA: 0x00013AF2 File Offset: 0x00011CF2
		public unsafe TMP_TextEventHandler TextEventHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventCheck.NativeFieldInfoPtr_TextEventHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_TextEventHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TMP_TextEventCheck.NativeFieldInfoPtr_TextEventHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001541 RID: 5441
		private static readonly IntPtr NativeFieldInfoPtr_TextEventHandler;

		// Token: 0x04001542 RID: 5442
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x04001543 RID: 5443
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x04001544 RID: 5444
		private static readonly IntPtr NativeMethodInfoPtr_OnCharacterSelection_Private_Void_Char_Int32_0;

		// Token: 0x04001545 RID: 5445
		private static readonly IntPtr NativeMethodInfoPtr_OnWordSelection_Private_Void_String_Int32_Int32_0;

		// Token: 0x04001546 RID: 5446
		private static readonly IntPtr NativeMethodInfoPtr_OnLineSelection_Private_Void_String_Int32_Int32_0;

		// Token: 0x04001547 RID: 5447
		private static readonly IntPtr NativeMethodInfoPtr_OnLinkSelection_Private_Void_String_String_Int32_0;

		// Token: 0x04001548 RID: 5448
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
