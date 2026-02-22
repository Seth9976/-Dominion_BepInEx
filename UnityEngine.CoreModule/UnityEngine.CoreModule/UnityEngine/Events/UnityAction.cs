using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Events
{
	// Token: 0x02000107 RID: 263
	public sealed class UnityAction : MulticastDelegate
	{
		// Token: 0x06001602 RID: 5634 RVA: 0x00053A78 File Offset: 0x00051C78
		// Note: this type is marked as 'beforefieldinit'.
		static UnityAction()
		{
			Il2CppClassPointerStore<UnityAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "UnityAction");
			UnityAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction>.NativeClassPtr, 100664930);
			UnityAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityAction>.NativeClassPtr, 100664931);
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00053AC8 File Offset: 0x00051CC8
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnityAction(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnityAction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00053B24 File Offset: 0x00051D24
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnityAction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x0000C7B3 File Offset: 0x0000A9B3
		public UnityAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x0000C7BC File Offset: 0x0000A9BC
		public static implicit operator UnityAction(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<UnityAction>(A_0);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x0000C7C4 File Offset: 0x0000A9C4
		public static UnityAction operator +(UnityAction A_0, UnityAction A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<UnityAction>();
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x0000C7D2 File Offset: 0x0000A9D2
		public static UnityAction operator -(UnityAction A_0, UnityAction A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<UnityAction>();
			}
			return delegate2;
		}

		// Token: 0x0400103E RID: 4158
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400103F RID: 4159
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
