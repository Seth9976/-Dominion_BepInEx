using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000003 RID: 3
	public sealed class UnityPurchasingCallback : MulticastDelegate
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002268 File Offset: 0x00000468
		// Note: this type is marked as 'beforefieldinit'.
		static UnityPurchasingCallback()
		{
			Il2CppClassPointerStore<UnityPurchasingCallback>.NativeClassPtr = IL2CPP.GetIl2CppClass("Purchasing.Common.dll", "UnityEngine.Purchasing", "UnityPurchasingCallback");
			UnityPurchasingCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasingCallback>.NativeClassPtr, 100663300);
			UnityPurchasingCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityPurchasingCallback>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022B8 File Offset: 0x000004B8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityPurchasingCallback(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityPurchasingCallback>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasingCallback.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002314 File Offset: 0x00000514
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 81202, RefRangeEnd = 81203, XrefRangeStart = 81202, XrefRangeEnd = 81203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(string subject, string payload, string receipt, string transactionId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(subject);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(payload);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(receipt);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(transactionId);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityPurchasingCallback.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002059 File Offset: 0x00000259
		public UnityPurchasingCallback(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002062 File Offset: 0x00000262
		public static implicit operator UnityPurchasingCallback(Action<string, string, string, string> A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityPurchasingCallback>(A_0);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000206A File Offset: 0x0000026A
		public static UnityPurchasingCallback operator +(UnityPurchasingCallback A_0, UnityPurchasingCallback A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityPurchasingCallback>();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002078 File Offset: 0x00000278
		public static UnityPurchasingCallback operator -(UnityPurchasingCallback A_0, UnityPurchasingCallback A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnityPurchasingCallback>();
			}
			return delegate2;
		}

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_String_String_String_0;
	}
}
