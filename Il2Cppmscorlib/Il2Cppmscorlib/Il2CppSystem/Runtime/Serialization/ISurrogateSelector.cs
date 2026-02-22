using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000330 RID: 816
	public class ISurrogateSelector : Il2CppObjectBase
	{
		// Token: 0x0600348D RID: 13453 RVA: 0x00012BBE File Offset: 0x00010DBE
		// Note: this type is marked as 'beforefieldinit'.
		static ISurrogateSelector()
		{
			Il2CppClassPointerStore<ISurrogateSelector>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization", "ISurrogateSelector");
			ISurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISurrogateSelector>.NativeClassPtr, 100671447);
		}

		// Token: 0x0600348E RID: 13454 RVA: 0x001012C8 File Offset: 0x000FF4C8
		[CallerCount(0)]
		public unsafe virtual ISerializationSurrogate GetSurrogate(Type type, StreamingContext context, out ISurrogateSelector selector)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISurrogateSelector.NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			selector = ((intPtr4 == 0) ? null : new ISurrogateSelector(intPtr4));
			IntPtr intPtr5 = intPtr2;
			return (intPtr5 != 0) ? Il2CppObjectPool.Get<ISerializationSurrogate>(intPtr5) : null;
		}

		// Token: 0x0600348F RID: 13455 RVA: 0x00012BED File Offset: 0x00010DED
		public ISurrogateSelector(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04002C90 RID: 11408
		private static readonly IntPtr NativeMethodInfoPtr_GetSurrogate_Public_Abstract_Virtual_New_ISerializationSurrogate_Type_StreamingContext_byref_ISurrogateSelector_0;
	}
}
