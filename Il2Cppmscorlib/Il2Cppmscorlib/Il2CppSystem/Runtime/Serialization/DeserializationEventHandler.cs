using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000326 RID: 806
	[Serializable]
	public sealed class DeserializationEventHandler : MulticastDelegate
	{
		// Token: 0x0600343C RID: 13372 RVA: 0x000FFEFC File Offset: 0x000FE0FC
		// Note: this type is marked as 'beforefieldinit'.
		static DeserializationEventHandler()
		{
			Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "DeserializationEventHandler");
			DeserializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr, 100671401);
			DeserializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr, 100671402);
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x000FFF4C File Offset: 0x000FE14C
		[CallerCount(1135)]
		[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DeserializationEventHandler(Object @object, IntPtr method)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeserializationEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationEventHandler.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x000FFFA8 File Offset: 0x000FE1A8
		[CallerCount(277)]
		[CachedScanResults(RefRangeStart = 94180, RefRangeEnd = 94457, XrefRangeStart = 94180, XrefRangeEnd = 94457, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DeserializationEventHandler.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00012A18 File Offset: 0x00010C18
		public DeserializationEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06003440 RID: 13376 RVA: 0x00012A21 File Offset: 0x00010C21
		public static implicit operator DeserializationEventHandler(Action<Object> A_0)
		{
			return DelegateSupport.ConvertDelegate<DeserializationEventHandler>(A_0);
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00012A29 File Offset: 0x00010C29
		public static DeserializationEventHandler operator +(DeserializationEventHandler A_0, DeserializationEventHandler A_1)
		{
			return Delegate.Combine(A_0, A_1).Cast<DeserializationEventHandler>();
		}

		// Token: 0x06003442 RID: 13378 RVA: 0x00012A37 File Offset: 0x00010C37
		public static DeserializationEventHandler operator -(DeserializationEventHandler A_0, DeserializationEventHandler A_1)
		{
			Delegate delegate2;
			Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
			if (@delegate != null)
			{
				delegate2 = @delegate.Cast<DeserializationEventHandler>();
			}
			return delegate2;
		}

		// Token: 0x04002C5F RID: 11359
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

		// Token: 0x04002C60 RID: 11360
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Object_0;
	}
}
