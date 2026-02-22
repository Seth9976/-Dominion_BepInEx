using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200007C RID: 124
	public class ILogHandler : Il2CppObjectBase
	{
		// Token: 0x06000C3D RID: 3133 RVA: 0x000340A4 File Offset: 0x000322A4
		// Note: this type is marked as 'beforefieldinit'.
		static ILogHandler()
		{
			Il2CppClassPointerStore<ILogHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ILogHandler");
			ILogHandler.NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogHandler>.NativeClassPtr, 100663945);
			ILogHandler.NativeMethodInfoPtr_LogException_Public_Abstract_Virtual_New_Void_Exception_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ILogHandler>.NativeClassPtr, 100663946);
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x000340F4 File Offset: 0x000322F4
		[CallerCount(0)]
		public unsafe virtual void LogFormat(LogType logType, Object context, string format, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref logType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(format);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogHandler.NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x00034184 File Offset: 0x00032384
		[CallerCount(0)]
		public unsafe virtual void LogException(Exception exception, Object context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exception);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ILogHandler.NativeMethodInfoPtr_LogException_Public_Abstract_Virtual_New_Void_Exception_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x00008FC0 File Offset: 0x000071C0
		public virtual void LogFormat(LogType logType, Object context, string format, params Object[] args)
		{
			this.LogFormat(logType, context, format, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x00008FD2 File Offset: 0x000071D2
		public ILogHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009D4 RID: 2516
		private static readonly IntPtr NativeMethodInfoPtr_LogFormat_Public_Abstract_Virtual_New_Void_LogType_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x040009D5 RID: 2517
		private static readonly IntPtr NativeMethodInfoPtr_LogException_Public_Abstract_Virtual_New_Void_Exception_Object_0;
	}
}
