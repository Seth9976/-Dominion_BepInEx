using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000272 RID: 626
	public sealed class ParameterizedThreadStart : MulticastDelegate
	{
		// Token: 0x06002B0E RID: 11022 RVA: 0x000DDA14 File Offset: 0x000DBC14
		// Note: this type is marked as 'beforefieldinit'.
		static ParameterizedThreadStart()
		{
			Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "ParameterizedThreadStart");
			ParameterizedThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr, 100670147);
			ParameterizedThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr, 100670148);
		}

		// Token: 0x06002B0F RID: 11023 RVA: 0x000DDA64 File Offset: 0x000DBC64
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParameterizedThreadStart(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParameterizedThreadStart>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedThreadStart.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B10 RID: 11024 RVA: 0x000DDAC0 File Offset: 0x000DBCC0
		[CallerCount(277)]
		[CachedScanResults(RefRangeStart = 94180, RefRangeEnd = 94457, XrefRangeStart = 94180, XrefRangeEnd = 94457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParameterizedThreadStart.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x0000F02F File Offset: 0x0000D22F
		public ParameterizedThreadStart(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x0000F038 File Offset: 0x0000D238
		public static implicit operator ParameterizedThreadStart(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<ParameterizedThreadStart>(A_0);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x0000F040 File Offset: 0x0000D240
		public static ParameterizedThreadStart operator +(ParameterizedThreadStart A_0, ParameterizedThreadStart A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<ParameterizedThreadStart>();
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x0000F04E File Offset: 0x0000D24E
		public static ParameterizedThreadStart operator -(ParameterizedThreadStart A_0, ParameterizedThreadStart A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<ParameterizedThreadStart>();
			}
			return delegate2;
		}

		// Token: 0x040025A3 RID: 9635
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040025A4 RID: 9636
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
