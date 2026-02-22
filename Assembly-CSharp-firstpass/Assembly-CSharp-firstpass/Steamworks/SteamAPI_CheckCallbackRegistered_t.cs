using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020002D0 RID: 720
	public sealed class SteamAPI_CheckCallbackRegistered_t : MulticastDelegate
	{
		// Token: 0x060029AA RID: 10666 RVA: 0x000B2FE8 File Offset: 0x000B11E8
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPI_CheckCallbackRegistered_t()
		{
			Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPI_CheckCallbackRegistered_t");
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100668587);
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100668588);
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100668589);
			SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr, 100668590);
		}

		// Token: 0x060029AB RID: 10667 RVA: 0x000B3060 File Offset: 0x000B1260
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamAPI_CheckCallbackRegistered_t(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamAPI_CheckCallbackRegistered_t>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029AC RID: 10668 RVA: 0x000B30BC File Offset: 0x000B12BC
		[CallerCount(16)]
		[CachedScanResults(RefRangeStart = 84530, RefRangeEnd = 84546, XrefRangeStart = 84530, XrefRangeEnd = 84546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int iCallbackNum)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCallbackNum;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029AD RID: 10669 RVA: 0x000B30FC File Offset: 0x000B12FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210402, XrefRangeEnd = 210406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int iCallbackNum, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref iCallbackNum;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060029AE RID: 10670 RVA: 0x000B316C File Offset: 0x000B136C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 43385, RefRangeEnd = 43388, XrefRangeStart = 43385, XrefRangeEnd = 43388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndInvoke(IAsyncResult result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPI_CheckCallbackRegistered_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029AF RID: 10671 RVA: 0x00010CB7 File Offset: 0x0000EEB7
		public SteamAPI_CheckCallbackRegistered_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060029B0 RID: 10672 RVA: 0x00010CC0 File Offset: 0x0000EEC0
		public static implicit operator SteamAPI_CheckCallbackRegistered_t(Action<int> A_0)
		{
			return DelegateSupport.ConvertDelegate<SteamAPI_CheckCallbackRegistered_t>(A_0);
		}

		// Token: 0x060029B1 RID: 10673 RVA: 0x00010CC8 File Offset: 0x0000EEC8
		public static SteamAPI_CheckCallbackRegistered_t operator +(SteamAPI_CheckCallbackRegistered_t A_0, SteamAPI_CheckCallbackRegistered_t A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SteamAPI_CheckCallbackRegistered_t>();
		}

		// Token: 0x060029B2 RID: 10674 RVA: 0x00010CD6 File Offset: 0x0000EED6
		public static SteamAPI_CheckCallbackRegistered_t operator -(SteamAPI_CheckCallbackRegistered_t A_0, SteamAPI_CheckCallbackRegistered_t A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SteamAPI_CheckCallbackRegistered_t>();
			}
			return delegate2;
		}

		// Token: 0x0400282B RID: 10283
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400282C RID: 10284
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_0;

		// Token: 0x0400282D RID: 10285
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_AsyncCallback_Object_0;

		// Token: 0x0400282E RID: 10286
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
