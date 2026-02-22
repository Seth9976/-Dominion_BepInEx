using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime
{
	// Token: 0x02000038 RID: 56
	public sealed class PrimalityTest : MulticastDelegate
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x00031A50 File Offset: 0x0002FC50
		// Note: this type is marked as 'beforefieldinit'.
		static PrimalityTest()
		{
			Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Math.Prime", "PrimalityTest");
			PrimalityTest.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr, 100663856);
			PrimalityTest.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr, 100663857);
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00031AA0 File Offset: 0x0002FCA0
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PrimalityTest(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTest.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00031AFC File Offset: 0x0002FCFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11513, RefRangeEnd = 11515, XrefRangeStart = 11513, XrefRangeEnd = 11515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Invoke(BigInteger bi, ConfidenceFactor confidence)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bi);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref confidence;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PrimalityTest.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00003A53 File Offset: 0x00001C53
		public PrimalityTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00003A5C File Offset: 0x00001C5C
		public static implicit operator PrimalityTest(Func<BigInteger, ConfidenceFactor, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<PrimalityTest>(A_0);
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00003A64 File Offset: 0x00001C64
		public static PrimalityTest operator +(PrimalityTest A_0, PrimalityTest A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PrimalityTest>();
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00003A72 File Offset: 0x00001C72
		public static PrimalityTest operator -(PrimalityTest A_0, PrimalityTest A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<PrimalityTest>();
			}
			return delegate2;
		}

		// Token: 0x040002D2 RID: 722
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x040002D3 RID: 723
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0;
	}
}
