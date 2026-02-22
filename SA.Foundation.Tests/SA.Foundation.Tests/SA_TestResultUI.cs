using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace SA.Foundation.Tests
{
	// Token: 0x0200000B RID: 11
	public class SA_TestResultUI : MonoBehaviour
	{
		// Token: 0x0600005C RID: 92 RVA: 0x00003554 File Offset: 0x00001754
		// Note: this type is marked as 'beforefieldinit'.
		static SA_TestResultUI()
		{
			Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.Tests.dll", "SA.Foundation.Tests", "SA_TestResultUI");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr);
			SA_TestResultUI.NativeFieldInfoPtr_m_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr, "m_text");
			SA_TestResultUI.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr, 100663337);
			SA_TestResultUI.NativeMethodInfoPtr_TestStartedHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr, 100663338);
			SA_TestResultUI.NativeMethodInfoPtr_GroupTestStartedHandler_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr, 100663339);
			SA_TestResultUI.NativeMethodInfoPtr_TestResultHandler_Private_Void_SA_TestResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr, 100663340);
			SA_TestResultUI.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr, 100663341);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000035FC File Offset: 0x000017FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158831, XrefRangeEnd = 158890, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResultUI.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00003630 File Offset: 0x00001830
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158890, XrefRangeEnd = 158894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestStartedHandler(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResultUI.NativeMethodInfoPtr_TestStartedHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00003674 File Offset: 0x00001874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158894, XrefRangeEnd = 158898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GroupTestStartedHandler(string obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResultUI.NativeMethodInfoPtr_GroupTestStartedHandler_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000036B8 File Offset: 0x000018B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158898, XrefRangeEnd = 158911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TestResultHandler(SA_TestResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResultUI.NativeMethodInfoPtr_TestResultHandler_Private_Void_SA_TestResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000036FC File Offset: 0x000018FC
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_TestResultUI()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_TestResultUI>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_TestResultUI.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002275 File Offset: 0x00000475
		public SA_TestResultUI(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00003738 File Offset: 0x00001938
		// (set) Token: 0x06000064 RID: 100 RVA: 0x0000227E File Offset: 0x0000047E
		public unsafe Text m_text
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestResultUI.NativeFieldInfoPtr_m_text);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_TestResultUI.NativeFieldInfoPtr_m_text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr_m_text;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeMethodInfoPtr_TestStartedHandler_Private_Void_String_0;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_GroupTestStartedHandler_Private_Void_String_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_TestResultHandler_Private_Void_SA_TestResult_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
