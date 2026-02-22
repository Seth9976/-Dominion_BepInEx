using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x02000047 RID: 71
	[Serializable]
	public sealed class MatchEvaluator : MulticastDelegate
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x0002166C File Offset: 0x0001F86C
		// Note: this type is marked as 'beforefieldinit'.
		static MatchEvaluator()
		{
			Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "MatchEvaluator");
			MatchEvaluator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100663944);
			MatchEvaluator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr, 100663945);
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000216BC File Offset: 0x0001F8BC
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MatchEvaluator(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchEvaluator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEvaluator.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00021718 File Offset: 0x0001F918
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 37559, RefRangeEnd = 37564, XrefRangeStart = 37559, XrefRangeEnd = 37559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string Invoke(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchEvaluator.NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x000037F9 File Offset: 0x000019F9
		public MatchEvaluator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00003802 File Offset: 0x00001A02
		public static implicit operator MatchEvaluator(Func<Match, string> A_0)
		{
			return DelegateSupport.ConvertDelegate<MatchEvaluator>(A_0);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0000380A File Offset: 0x00001A0A
		public static MatchEvaluator operator +(MatchEvaluator A_0, MatchEvaluator A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<MatchEvaluator>();
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00003818 File Offset: 0x00001A18
		public static MatchEvaluator operator -(MatchEvaluator A_0, MatchEvaluator A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<MatchEvaluator>();
			}
			return delegate2;
		}

		// Token: 0x0400035A RID: 858
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x0400035B RID: 859
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_String_Match_0;
	}
}
