const schemaList = [
    {
        name: 'paramTranslate',
        desc: 'Translate the given word',
        paramDefines: [
            {name: 'paramName', type: 'string'}
        ]
    },
    {
        name: 'imgRotate',
        desc: 'Rotate Image',
        paramDefines: [
            {name: 'base64', type: 'string'},
            {
                name: 'direction',
                type: 'string',
                defineValues: [
                    {name: 'left'},
                    {name: 'right'}
                ]
            }
        ]
    }
]