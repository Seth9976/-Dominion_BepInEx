using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Steamworks
{
	// Token: 0x020002CF RID: 719
	public sealed class SteamAPIWarningMessageHook_t : MulticastDelegate
	{
		// Token: 0x060029A1 RID: 10657 RVA: 0x000B2DFC File Offset: 0x000B0FFC
		// Note: this type is marked as 'beforefieldinit'.
		static SteamAPIWarningMessageHook_t()
		{
			Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "SteamAPIWarningMessageHook_t");
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100668583);
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100668584);
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100668585);
			SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr, 100668586);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x000B2E74 File Offset: 0x000B1074
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SteamAPIWarningMessageHook_t(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SteamAPIWarningMessageHook_t>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x000B2ED0 File Offset: 0x000B10D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 46351, RefRangeEnd = 46356, XrefRangeStart = 46351, XrefRangeEnd = 46356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(int nSeverity, StringBuilder pchDebugText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSeverity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pchDebugText);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x000B2F20 File Offset: 0x000B1120
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210398, XrefRangeEnd = 210402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(int nSeverity, StringBuilder pchDebugText, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nSeverity;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pchDebugText);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000B2FA4 File Offset: 0x000B11A4
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamAPIWarningMessageHook_t.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x00010C87 File Offset: 0x0000EE87
		public SteamAPIWarningMessageHook_t(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x00010C90 File Offset: 0x0000EE90
		public static implicit operator SteamAPIWarningMessageHook_t(Action<int, StringBuilder> A_0)
		{
			return DelegateSupport.ConvertDelegate<SteamAPIWarningMessageHook_t>(A_0);
		}

		// Token: 0x060029A8 RID: 10664 RVA: 0x00010C98 File Offset: 0x0000EE98
		public static SteamAPIWarningMessageHook_t operator +(SteamAPIWarningMessageHook_t A_0, SteamAPIWarningMessageHook_t A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<SteamAPIWarningMessageHook_t>();
		}

		// Token: 0x060029A9 RID: 10665 RVA: 0x00010CA6 File Offset: 0x0000EEA6
		public static SteamAPIWarningMessageHook_t operator -(SteamAPIWarningMessageHook_t A_0, SteamAPIWarningMessageHook_t A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<SteamAPIWarningMessageHook_t>();
			}
			return delegate2;
		}

		// Token: 0x04002827 RID: 10279
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002828 RID: 10280
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Int32_StringBuilder_0;

		// Token: 0x04002829 RID: 10281
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Int32_StringBuilder_AsyncCallback_Object_0;

		// Token: 0x0400282A RID: 10282
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
