using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Assertions
{
	// Token: 0x02000173 RID: 371
	public class AssertionException : Exception
	{
		// Token: 0x06001B8B RID: 7051 RVA: 0x00061318 File Offset: 0x0005F518
		// Note: this type is marked as 'beforefieldinit'.
		static AssertionException()
		{
			Il2CppClassPointerStore<AssertionException>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Assertions", "AssertionException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssertionException>.NativeClassPtr);
			AssertionException.NativeFieldInfoPtr_m_UserMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, "m_UserMessage");
			AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100665299);
			AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssertionException>.NativeClassPtr, 100665300);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x00061384 File Offset: 0x0005F584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83279, XrefRangeEnd = 83283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AssertionException(string message, string userMessage)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AssertionException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(userMessage);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AssertionException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001B8D RID: 7053 RVA: 0x000613E4 File Offset: 0x0005F5E4
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83283, XrefRangeEnd = 83287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AssertionException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0000F13B File Offset: 0x0000D33B
		public AssertionException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x00061428 File Offset: 0x0005F628
		// (set) Token: 0x06001B90 RID: 7056 RVA: 0x0000F144 File Offset: 0x0000D344
		public unsafe string m_UserMessage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AssertionException.NativeFieldInfoPtr_m_UserMessage), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001529 RID: 5417
		private static readonly IntPtr NativeFieldInfoPtr_m_UserMessage;

		// Token: 0x0400152A RID: 5418
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400152B RID: 5419
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;
	}
}
