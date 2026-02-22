using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000066 RID: 102
	public sealed class Action : MulticastDelegate
	{
		// Token: 0x060006A5 RID: 1701 RVA: 0x0003FEA0 File Offset: 0x0003E0A0
		// Note: this type is marked as 'beforefieldinit'.
		static Action()
		{
			Il2CppClassPointerStore<Action>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "Action");
			Action.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action>.NativeClassPtr, 100664353);
			Action.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Action>.NativeClassPtr, 100664354);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0003FEF0 File Offset: 0x0003E0F0
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Action>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0003FF4C File Offset: 0x0003E14C
		[CallerCount(149)]
		[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Action.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000422B File Offset: 0x0000242B
		public Action(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00004234 File Offset: 0x00002434
		public static implicit operator Action(Action A_0)
		{
			return DelegateSupport.ConvertDelegate<Action>(A_0);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000423C File Offset: 0x0000243C
		public static Action operator +(Action A_0, Action A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<Action>();
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000424A File Offset: 0x0000244A
		public static Action operator -(Action A_0, Action A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<Action>();
			}
			return delegate2;
		}

		// Token: 0x040004E6 RID: 1254
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040004E7 RID: 1255
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
	}
}
