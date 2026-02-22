using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Text;

namespace Steamworks
{
	// Token: 0x020002EC RID: 748
	public sealed class FSteamNetworkingSocketsDebugOutput : MulticastDelegate
	{
		// Token: 0x06002B36 RID: 11062 RVA: 0x000B95A8 File Offset: 0x000B77A8
		// Note: this type is marked as 'beforefieldinit'.
		static FSteamNetworkingSocketsDebugOutput()
		{
			Il2CppClassPointerStore<FSteamNetworkingSocketsDebugOutput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp-firstpass.dll", "Steamworks", "FSteamNetworkingSocketsDebugOutput");
			FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSteamNetworkingSocketsDebugOutput>.NativeClassPtr, 100668880);
			FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ESteamNetworkingSocketsDebugOutputType_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSteamNetworkingSocketsDebugOutput>.NativeClassPtr, 100668881);
			FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ESteamNetworkingSocketsDebugOutputType_StringBuilder_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSteamNetworkingSocketsDebugOutput>.NativeClassPtr, 100668882);
			FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSteamNetworkingSocketsDebugOutput>.NativeClassPtr, 100668883);
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000B9620 File Offset: 0x000B7820
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FSteamNetworkingSocketsDebugOutput(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSteamNetworkingSocketsDebugOutput>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000B967C File Offset: 0x000B787C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pszMsg);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ESteamNetworkingSocketsDebugOutputType_StringBuilder_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000B96CC File Offset: 0x000B78CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 210888, XrefRangeEnd = 210892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginInvoke(ESteamNetworkingSocketsDebugOutputType nType, StringBuilder pszMsg, AsyncCallback callback, Object @object)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pszMsg);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ESteamNetworkingSocketsDebugOutputType_StringBuilder_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000B9750 File Offset: 0x000B7950
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSteamNetworkingSocketsDebugOutput.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B3B RID: 11067 RVA: 0x00011129 File Offset: 0x0000F329
		public FSteamNetworkingSocketsDebugOutput(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B3C RID: 11068 RVA: 0x00011132 File Offset: 0x0000F332
		public static implicit operator FSteamNetworkingSocketsDebugOutput(Action<ESteamNetworkingSocketsDebugOutputType, StringBuilder> A_0)
		{
			return DelegateSupport.ConvertDelegate<FSteamNetworkingSocketsDebugOutput>(A_0);
		}

		// Token: 0x06002B3D RID: 11069 RVA: 0x0001113A File Offset: 0x0000F33A
		public static FSteamNetworkingSocketsDebugOutput operator +(FSteamNetworkingSocketsDebugOutput A_0, FSteamNetworkingSocketsDebugOutput A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<FSteamNetworkingSocketsDebugOutput>();
		}

		// Token: 0x06002B3E RID: 11070 RVA: 0x00011148 File Offset: 0x0000F348
		public static FSteamNetworkingSocketsDebugOutput operator -(FSteamNetworkingSocketsDebugOutput A_0, FSteamNetworkingSocketsDebugOutput A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<FSteamNetworkingSocketsDebugOutput>();
			}
			return delegate2;
		}

		// Token: 0x0400298D RID: 10637
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400298E RID: 10638
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ESteamNetworkingSocketsDebugOutputType_StringBuilder_0;

		// Token: 0x0400298F RID: 10639
		private static readonly IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ESteamNetworkingSocketsDebugOutputType_StringBuilder_AsyncCallback_Object_0;

		// Token: 0x04002990 RID: 10640
		private static readonly IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
	}
}
