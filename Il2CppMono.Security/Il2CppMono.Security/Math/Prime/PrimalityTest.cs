using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Math.Prime
{
	// Token: 0x02000033 RID: 51
	public sealed class PrimalityTest : MulticastDelegate
	{
		// Token: 0x060002AD RID: 685 RVA: 0x0000DA20 File Offset: 0x0000BC20
		// Note: this type is marked as 'beforefieldinit'.
		static PrimalityTest()
		{
			Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Math.Prime", "PrimalityTest");
			PrimalityTest.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr, 100663689);
			PrimalityTest.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrimalityTest>.NativeClassPtr, 100663690);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000DA70 File Offset: 0x0000BC70
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

		// Token: 0x060002AF RID: 687 RVA: 0x0000DACC File Offset: 0x0000BCCC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 11513, RefRangeEnd = 11515, XrefRangeStart = 11513, XrefRangeEnd = 11513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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

		// Token: 0x060002B0 RID: 688 RVA: 0x0000326F File Offset: 0x0000146F
		public PrimalityTest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003278 File Offset: 0x00001478
		public static implicit operator PrimalityTest(Func<BigInteger, ConfidenceFactor, bool> A_0)
		{
			return DelegateSupport.ConvertDelegate<PrimalityTest>(A_0);
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00003280 File Offset: 0x00001480
		public static PrimalityTest operator +(PrimalityTest A_0, PrimalityTest A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<PrimalityTest>();
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000328E File Offset: 0x0000148E
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

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Boolean_BigInteger_ConfidenceFactor_0;
	}
}
